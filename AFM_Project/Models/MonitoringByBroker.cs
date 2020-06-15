using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class MonitoringByBroker
    {
        public int IdBroker { get; set; }
        public int? ExecApistatus { get; set; }
        public int? ExecApimonitoringStatus { get; set; }
        public DateTime? ExecApilastMonitoring { get; set; }
    }
}
