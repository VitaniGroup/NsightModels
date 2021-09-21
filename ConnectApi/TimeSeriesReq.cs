using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsightModels.ConnectApi
{
	public enum Interval
	{
		Minutes = 0,
		Hours = 1,
		Days = 2
	}

	public class TimeSeriesReq
	{
		public DateTime startDate { get; set; }
		public DateTime endDate { get; set; }
		public string majorId { get; set; }
		public string minorId { get; set; }
		public int intervalCount { get; set; }
		public Interval interval { get; set; }

	}
}
