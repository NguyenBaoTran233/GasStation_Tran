using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Models
{
    public class Feedback
    {
        public String GasStationName { get; set; }
        public String GasType { get; set; }
        public String Address { get; set; }
        public String StartTime { get; set; }
        public String Rating { get; set; }
        public String ListUp { get; set; }
        public String TimeUp { get; set; }
        public String Content { get; set; }
    }
}
