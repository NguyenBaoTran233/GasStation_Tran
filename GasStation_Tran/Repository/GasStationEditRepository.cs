using Dapper;
using GasStation_Tran.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Repository
{
    public class GasStationEditRepository : IGasStationEdit
    {
        private IDbConnection db;
        public GasStationEditRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

     

        public List<GasStationEdit> GetAllGasStationEdit()
        {
            var sql = "SELECT * FROM [dbo].[GasStation]";
            var result = db.Query<GasStationEdit>(sql).ToList();
            return result;
        }
    }
}
