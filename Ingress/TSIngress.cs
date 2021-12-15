using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Runtime.Serialization;


namespace NsightModels.Ingress
{
	public class TSIngress
	{
        [SwaggerExclude]
        public Guid OrgUUID { get; set; }
        [JsonProperty(Required = Required.Always)]
        public Guid SystemID { get; set; }
        public string MajorID { get; set; }
        public string MinorID { get; set; }
        public Guid ValueGroupID { get; set; }
        public Guid EventID { get; set; }
        public DateTime MTime { get; set; }
        public double MValue { get; set; }
    }
}
