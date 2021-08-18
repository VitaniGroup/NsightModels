using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsightModels.Data
{
	public class IoT_TSData
	{
        public Guid OrgUUID { get; set; }
        public int SystemID { get; set; }
        public string DeviceID { get; set; }
        public string SensorID { get; set; }
        public Guid ValueGroupId { get; set; }
        public Guid EventId { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Value { get; set; }
    }
}
