using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Models
{
    public class GasStationType
    {
        public int TypeId { get; set; }
        public String TypeCode { get; set; }
        public String TypeText { get; set; }
        public bool Selected { get; set; }
    }
}
