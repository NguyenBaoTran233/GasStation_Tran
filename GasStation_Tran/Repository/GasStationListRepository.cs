using Dapper;
using GasStation_Tran.Models;
using GasStation_Tran.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Repository
{
    public class GasStationListRepository : IGasStationList
    {
        private IDbConnection db;
        public GasStationListRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public long Add(GasStationViewModels stationViewModels)
        {
            var sql = "INSERT INTO GasStation (GasStationName, Address, District, OpeningTime , Longitude, Latitude, Rating, InsertedAt, InsertedBy, UpdatedAt, UpdatedBy, DeletedAt, DeletedBy) " +
                "VALUES(@GasStationName, @Address, @District, @OpeningTime , @Longitude, @Latitude, @Rating, @InsertedAt, @InsertedBy, @UpdatedAt, @UpdatedBy, @DeletedAt,@DeletedBy); " +
                "SELECT CAST(SCOPE_IDENTITY() as bigint);";
            var id = db.Query<long>(sql, new
            {
                @GasStationName=stationViewModels.GasStationAdd.GasStationName,
                @Address = stationViewModels.GasStationAdd.Address,
                @District = stationViewModels.DistrictId,
                @OpeningTime = stationViewModels.GasStationAdd.OpeningTime,
                @Longitude = stationViewModels.GasStationAdd.Longitude,
                @Latitude = stationViewModels.GasStationAdd.Latitude,
                @Rating = stationViewModels.TypeCode,
                @InsertedAt = DateTime.Now,
                @InsertedBy = stationViewModels.GasStationAdd.InsertedBy,
                @UpdatedAt = string.Empty,
                @UpdatedBy = string.Empty,
                @DeletedAt = string.Empty,
                @DeletedBy = string.Empty,
            }).Single();
            if(id > 0)
            {
                foreach (var itemAdd in stationViewModels.lstGasStationType)
                {
                    if(itemAdd.Selected == true)
                    {
                        var sqlAdd = "INSERT INTO [dbo].[GasStationGasType] ([GasStationId],[GasType]) " +
                                     "VALUES(@GasStationId, @GasType); " +
                                     "SELECT CAST(SCOPE_IDENTITY() as bigint);";
                        var idAdd = db.Query<long>(sqlAdd,new {
                            @GasStationId = id,
                            @GasType = itemAdd.TypeCode,
                        }).Single();
                    }
                }
            }
            return id;
        }

        public List<GasStationTable> GetAllStationtable()
        {
            var sql =
                "       SELECT  G.GasStationId, G.GasStationName,G.Latitude,G.Longitude,G.OpeningTime,G.District,G.Address " +
                "		        ,MF.TypeCode " +
                "		        ,MD.DistrictId " +
                "		        ,examp.GasStationType ,examp.GasStationTypeCode " +
                "       FROM GasStation G  " +
                "       left join M_GasStationFeedback MF on MF.TypeCode = G.Rating " +
                "       left join M_District MD on G.District = MD.DistrictId " +
                "       left join( " +
                "                   SELECT GasStationGasType.GasStationId, STRING_AGG(MT.TypeText, ',') As[GasStationType], " +
                "			        STRING_AGG(MT.TypeCode, ',') As[GasStationTypeCode] " +
                "                   FROM GasStationGasType " +
                "                   LEFT JOIN M_GasStationType MT ON MT.TypeCode = GasStationGasType.GasType " +
                "                   GROUP BY GasStationGasType.GasStationId " +
                "		        ) as examp on examp.GasStationId = G.GasStationId " +
                "         WHERE ISNULL(G.DeletedBy, 0) = 0 " +
                "         order by G.GasStationName  "; 
            var result_table = db.Query<GasStationTable>(sql).ToList();
            return result_table;
        }

        public List<GasStationTable> GetAllStationtableSearch(GasStationViewModels stationViewModels)
        {
            var sql =
        "       SELECT  G.GasStationId, G.GasStationName,G.Latitude,G.Longitude,G.OpeningTime,G.District,G.Address " +
        "		        ,MF.TypeCode " +
        "		        ,MD.DistrictName " +
        "		        ,examp.GasStationType ,examp.GasStationTypeCode " +
        "       FROM GasStation G  " +
        "       left join M_GasStationFeedback MF on MF.TypeCode = G.Rating " +
        "       left join M_District MD on G.District = MD.DistrictId " +
        "       left join( " +
        "                   SELECT GasStationGasType.GasStationId, STRING_AGG(MT.TypeText, ',') As[GasStationType], " +
        "			        STRING_AGG(MT.TypeCode, ',') As[GasStationTypeCode] " +
        "                   FROM GasStationGasType " +
        "                   LEFT JOIN M_GasStationType MT ON MT.TypeCode = GasStationGasType.GasType " +
        "                   GROUP BY GasStationGasType.GasStationId " +
        "		        ) as examp on examp.GasStationId = G.GasStationId " +
        "         WHERE ISNULL(G.DeletedBy, 0) = 0 " +
        "         order by G.GasStationName  ";
            var result = db.Query<GasStationTable>(sql).ToList();
            if(stationViewModels != null)
            {
                result = result.Where(t =>
                                       (string.IsNullOrWhiteSpace(stationViewModels.GasStationNameSearch) || t.GasStationName.ToLower().Contains(stationViewModels.GasStationNameSearch.ToLower())) &&
                                       (t.District.Equals(stationViewModels.DistrictId.ToString()) || stationViewModels.DistrictId == 0)
                                       )
                                   .ToList();
                var checkbox = stationViewModels.lstGasStationType.FirstOrDefault(x => x.Selected == true);
                if(checkbox != null)
                {
                    var temp = new List<GasStationTable>();
                    if(stationViewModels.lstGasStationType != null)
                    {
                        foreach (var item in result)
                        {
                            foreach(var item1 in stationViewModels.lstGasStationType)
                            {
                                if(item1.Selected == true && item.GasStationType.Contains(item1.TypeText))
                                {
                                    temp.Add(item);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        return result;
                    }
                    return temp;
                }
                else
                {
                    return result;
                }
            }
            else
            {
                return result;
            }
        }

        public List<GasStationList> GetStationLists()
        {
            var sql = "SELECT * FROM [dbo].[GasStation]";
            var result = db.Query<GasStationList>(sql).ToList();
            return result;
        }

        public long Remove(GasStationViewModels stationViewModels, int id)
        {
            var sql = "Update  [dbo].[GasStation] SET DeletedBy = @DeletedBy , DeletedAt = @DeletedAt where GasStationId = @GasStationId";
            db.Execute(sql, new
            {
                @DeletedBy = stationViewModels.DeleteBy,
                @DeletedAt = DateTime.Now,
                @GasStationId = id
            });
            return id;
        }

        public long Update(GasStationViewModels stationViewModels, int id)
        {
            var sql = "UPDATE GasStation SET GasStationName=@GasStationName, Address = @Address, District = @District, OpeningTime = @OpeningTime , Longitude = @Longitude, Latitude = @Latitude, Rating = @Rating, " +
               " UpdatedAt = @UpdatedAt, UpdatedBy = @UpdatedBy, DeletedAt = @DeletedAt, DeletedBy = @DeletedBy Where GasStationId = @GasStationId";
            db.Execute(sql, new
            {
                @GasStationName= stationViewModels.GasStationAdd.GasStationName,
                @Address = stationViewModels.GasStationAdd.Address,
                @District = stationViewModels.GasStationAdd.DistrictId,
                @OpeningTime = stationViewModels.GasStationAdd.OpeningTime,
                @Longitude = stationViewModels.GasStationAdd.Longitude,
                @Latitude = stationViewModels.GasStationAdd.Latitude,
                @Rating = stationViewModels.TypeCode,
                @UpdatedAt =DateTime.Now,
                @UpdatedBy=stationViewModels.GasStationAdd.UpdatedBy,
                @DeletedAt=string.Empty,
                @DeletedBy=string.Empty,
                @GasStationId =id
            });
            if(id > 0)
            {
                var sqlDelete = "Delete from[dbo].[GasStationGasType] where GasStationId = @Id";
                db.Execute(sqlDelete, new { id });
                foreach (var itemUpdate in stationViewModels.lstGasStationType)
                {
                    if(itemUpdate.Selected== true)
                    {
                        var sqlUpdate = "INSERT INTO [dbo].[GasStationGasType] ([GasStationId],[GasType]) " +
                                  "  VALUES(@GasStationId, @GasType); " +
                                     "SELECT CAST(SCOPE_IDENTITY() as bigint);";
                        var idUpdate = db.Query<long>(sqlUpdate, new {
                            @GasStationId=id,
                            @GasType = itemUpdate.TypeCode
                        }).Single();
                    }
                }
            }
            return id;
        }
    }
}
