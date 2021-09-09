using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Models
{
    public class GasStationTable
    {
        public int GasStationId { get; set; }
        public string GasStationName { get; set; }
        public string GasStationType { get; set; }
        public string Address { get; set; }
        public string DistrictName { get; set; }
        public string DistrictId { get; set; }
        public string District { get; set; }
        public string Rating { get; set; }
        public DateTime InsertedAt { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long? DeletedBy { get; set; }
        public string OpeningTime { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string TypeCode { get; set; }
        public string GasStationTypeCode { get; set; }
    }
}
