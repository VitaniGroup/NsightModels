﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsightModels.PushOut
{
	public class Message
    {
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Info Info { get; set; }
        public List<Data.TSIngress> Data { get; set; }
    }
}
