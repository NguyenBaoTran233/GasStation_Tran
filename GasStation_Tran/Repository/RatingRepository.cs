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
    public class RatingRepository: IRating
    {

        private IDbConnection db;
        public RatingRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public List<GasStationRating> GetAllRating()
        {
            var sql = "SELECT * FROM [dbo].[M_GasStationFeedback]";
            var result = db.Query<GasStationRating>(sql).ToList();
            return result;
        }
    }
}
