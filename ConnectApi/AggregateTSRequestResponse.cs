using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsightModels.ConnectApi
{

    public class AggregateTSRequest
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string majorId { get; set; }
        public string minorId { get; set; }

    }

    public class AggregateTSResponse
    {
        public string MajorID { get; set; }
        public string MinorID { get; set; }
        public Guid ValueGroupID { get; set; }
        public Guid EventID { get; set; }
        public DateTime MTime { get; set; }
        public double MValue { get; set; }
    }



}
