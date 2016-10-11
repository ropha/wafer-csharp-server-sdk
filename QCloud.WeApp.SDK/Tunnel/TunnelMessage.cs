﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QCloud.WeApp.SDK
{
    public class TunnelMessage
    {
        internal TunnelMessage(string messageRaw)
        {
            dynamic resolved = JsonConvert.DeserializeObject(messageRaw);
            Type = resolved.type;
            Content = resolved.content;
        }

        public string Type { get; internal set; }

        public dynamic Content { get; internal set; }
    }
}
