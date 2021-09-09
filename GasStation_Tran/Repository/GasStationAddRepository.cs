
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
    public class GasStationAddRepository : IGasStationAdd
    {
        private IDbConnection db;
        public GasStationAddRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public List<GasStationAdd> GetAllGasStationAdd()
        {
            var sql = "SELECT * FROM [dbo].[GasStation]";
            var result = db.Query<GasStationAdd>(sql).ToList();
            return result;
        }

       
    }
}
