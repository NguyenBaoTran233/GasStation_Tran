using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Models
{
    public class User
    {
        public String Email { get; set; }
        public String Password { get; set; }
        public int UserId { get; set; }
        public String UserType { get; set; }
    }
}
