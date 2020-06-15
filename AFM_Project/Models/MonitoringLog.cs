using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class MonitoringLog
    {
        public int? IdLog { get; set; }
        public DateTime? Datestamp { get; set; }
        public string Msg { get; set; }
        public int? MsgType { get; set; }
        public int? MsgSubtype { get; set; }
        public int? Severity { get; set; }
        public string Url { get; set; }
    }
}
