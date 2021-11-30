using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace NsightModels.Ingress
{
	public class TSIngress
	{
        [JsonIgnore]
        public Guid OrgUUID { get; set; }
        [JsonProperty(Required = Required.Always)]
        public Guid SystemID { get; set; }
        [JsonProperty(Required = Required.Always)]
        public string MajorID { get; set; }
        public string MinorID { get; set; }
        public Guid ValueGroupID { get; set; }
        public Guid EventID { get; set; }
        [JsonProperty(Required = Required.Always)]
        public DateTime MTime { get; set; }
        [JsonProperty(Required = Required.Always)]
        public double MValue { get; set; }
    }
}
