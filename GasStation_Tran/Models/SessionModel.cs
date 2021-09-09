using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Models
{
    public class SessionModel
    {
        public string UserName { get; set; }
        public int Id {get;set;}
    }
    public class KeySession
    {
        public const string KeyAccess = "Key_Session";
    }
}
