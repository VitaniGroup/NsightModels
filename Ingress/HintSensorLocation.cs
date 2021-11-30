using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NsightModels.Ingress
{
    class HintSensorLocation
    {
        [JsonProperty(Required = Required.Always)]
        public string MajorID { get; set; }
        [JsonProperty(Required = Required.Always)]
        public string MinorID { get; set; }
        public double Longitude { get; set; }
        public double latitude { get; set; }
        [JsonProperty(Required = Required.AllowNull)]
        public string LocationName { get; set; }

    }
}
