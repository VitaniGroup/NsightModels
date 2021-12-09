using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace NsightModels.Ingress
{
    public class HintSensorLocation
    {
        [IgnoreDataMember]
        public Guid OrgUUID { get; set; }
        public string MajorID { get; set; }
        public string MinorID { get; set; }
        public double Longitude { get; set; }
        public double latitude { get; set; }
        public string LocationName { get; set; }

    }
}
