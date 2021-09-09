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
    public class GasStationTypeRepository:IGasStationType
    {
         
        private IDbConnection db;
        public GasStationTypeRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

       

        public List<GasStationType> GetGasStationTypes()
        {
            var sql = "SELECT * FROM [dbo].[M_GasStationType]";
            var result = db.Query<GasStationType>(sql).ToList();
            return result;

        }
    }
}

