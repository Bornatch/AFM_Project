using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Monitoring
    {
        public int? ExecApistatus { get; set; }
        public int? MdiApistatus { get; set; }
        public int? ExecApimonitoringStatus { get; set; }
        public DateTime? ExecApilastMonitoring { get; set; }
        public DateTime? AlgoSlowTs { get; set; }
        public DateTime? AlgoFastTs { get; set; }
        public DateTime? AlgoCheckAutoTs { get; set; }
    }
}
