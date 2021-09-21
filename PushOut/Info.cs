using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsightModels.PushOut
{
    public class Info
    {
        public string DeviceName { get; set; }
        public string DeviceType { get; set; }
        public object Location { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public object Brand { get; set; }
        public object Model { get; set; }
        public object SerialNo { get; set; }
        public string Notes { get; set; }
    }
}
