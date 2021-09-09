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
    public class GasStationListFeedbackRepository : IGasStationListFeedback
    {
        private IDbConnection db;
        public GasStationListFeedbackRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public List<GasStationListFeedback> GetAllListFeedback()
        {
            var sql = "SELECT * FROM [dbo].[GasStationFeedback] ORDER BY FeedbackAt";
            var result = db.Query<GasStationListFeedback>(sql).ToList();
            return result;
        }

    }
}
