using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Models
{
    public class GasStationEdit
    {
        public String GasStationName { get; set; }
        public String GasStationType { get; set; }
        public String Longitude { get; set; }
        public String Latitude { get; set; }
        public String District { get; set; }
        public String Address { get; set; }
        public DateTime OpeningTime { get; set; }
        public String Rating { get; set; }
        public int InsertedBy { get; internal set; }
        public DateTime InsertedAt { get; internal set; }
    }
}
