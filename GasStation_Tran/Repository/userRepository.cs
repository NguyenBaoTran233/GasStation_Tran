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
    public class userRepository:IUser
    {
        private IDbConnection db;
        public userRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public User Login(User user)
        {
            if(user != null)
            {  
                var sql = "SELECT * FROM [dbo].[User]";
                var result = db.Query<User>(sql).ToList();
                if(result != null)
                {
                    return result.FirstOrDefault(x => x.Email.Equals(user.Email) && x.Password.Equals(user.Password));
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
