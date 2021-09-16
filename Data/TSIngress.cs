using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsightModels.Data
{
	public class TSIngress
	{
        public Guid OrgUUID { get; set; }
        public Guid SystemID { get; set; }
        public string MajorID { get; set; }
        public string MinorID { get; set; }
        public Guid ValueGroupID { get; set; }
        public Guid EventID { get; set; }
        public DateTime MTime { get; set; }
        public double MValue { get; set; }
    }
}
