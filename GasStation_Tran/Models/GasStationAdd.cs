using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Models
{
    public class GasStationAdd
    {
        [Key]
        public String GasStationName { get; set; }
        public String GasStationType { get; set; }
        public String Longitude { get; set; }
        public String Latitude { get; set; }
        public String District { get; set; }
        public String Address { get; set; }
        public DateTime OpeningTime { get; set; }
        public String Rating { get; set; }
    }
}
