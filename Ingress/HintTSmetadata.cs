using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NsightModels.Ingress
{
    public class HintTSmetadata
    {
        [JsonProperty(Required = Required.Always)]
        public string MajorID { get; set; }
        [JsonProperty(Required = Required.Always)]
        public string MinorID { get; set; }
        public string SensorType { get; set; }
        public string TSValueType { get; set; }
        public string TSValueUnit { get; set; }
        public string TSValueFactor { get; set; }
        [JsonProperty(Required = Required.Always)]
        public DateTime ValidFrom { get; set; }
        [JsonProperty(Required = Required.Always)]
        public DateTime ValidTo { get; set; }

    }
}
