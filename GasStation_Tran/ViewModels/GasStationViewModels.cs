using GasStation_Tran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.ViewModels
{
    public class GasStationViewModels
    {
        public int DistrictId { get; set; }
        public List<District> lstDistricts { get; set; }
        public List<GasStationType> lstGasStationType { get; set; }
        public List<GasStationTable>lstgasStationTables { get; set; }
        public List<GasStationListFeedback> lstGasStationFeedback { get; set; }
        public GasStationTable GasStationFeedback { get; set; }
        public GasStationTable GasStationAdd { get; set; }
        public GasStationTable GasStationEdit { get; set; }
        public List<GasStationRating> lstRating { get; set; }
        public string TypeCode { get; set; }
        public string DeleteBy { get; set; }
        public string GasStationNameSearch { get; set; }
    }
}
