using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Models
{
    public class Edit
    {
        public String GasStationName { get; set; }
        public String TypeGas { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public String District { get; set; }
        public String Address { get; set; }
        public String OpeningTime { get; set; }
        public String Rating { get; set; }
    }
}
