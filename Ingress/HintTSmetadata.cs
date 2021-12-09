using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace NsightModels.Ingress
{
    public class HintTSmetadata
    {
        [IgnoreDataMember]
        public Guid OrgUUID { get; set; }
        public string MajorID { get; set; }
        public string MinorID { get; set; }
        public string SensorType { get; set; }
        public string TSValueType { get; set; }
        public string TSValueUnit { get; set; }
        public string TSValueFactor { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

    }
}
