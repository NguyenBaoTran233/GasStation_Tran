using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Models
{
    public class GasStationListFeedback
    {
        public int GasStationId { get; set; }
        public String Feedback { get; set; }
        public DateTime FeedbackAt { get; set; }
    }
}
