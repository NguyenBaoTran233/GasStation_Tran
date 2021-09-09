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
    public class GasStationFeedbackRepository : IGasStationFeedback
    {
         
        private IDbConnection db;
        public GasStationFeedbackRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public List<GasStationFeedback> GetStationFeedback()
        {
            var sql = "SELECT * FROM [dbo].[M_GasStationFeedback]";
            var result = db.Query<GasStationFeedback>(sql).ToList();
            return result;
        }

    }
}

