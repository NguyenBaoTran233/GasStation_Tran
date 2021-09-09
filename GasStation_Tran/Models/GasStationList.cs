using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Models
{
    public class GasStationList
    {
        public int GasStationId { get; set; }
        public String GasStationName { get; set; }
        public String Address { get; set; }
        public String District { get; set; }
        public String OpeningTime { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public String Rating { get; set; }
        public DateTime InsertedAt { get; set; }
        public int InsertedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public int DeletedBy { get; set; }

    }
}
