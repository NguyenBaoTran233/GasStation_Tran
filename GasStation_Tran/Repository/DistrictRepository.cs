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
    public class DistrictRepository:IDistrict
    {
        private IDbConnection db;
        public DistrictRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public List<District> GetAllDistrict()
        {
            var sql = "SELECT* FROM M_District ORDER BY DistrictName";
            var result = db.Query<District>(sql).ToList();
            return result;
        }
    }
}
