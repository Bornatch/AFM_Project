using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class CmetConditions
    {
        public Guid IdCmetConditions { get; set; }
        public Guid? IdNewtrade { get; set; }
        public string Sell { get; set; }
        public double? ReqSavings { get; set; }
        public double? InitSavings { get; set; }
        public double? MaxSavings { get; set; }
        public double? TrailingSavings { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? Status { get; set; }
        public DateTime? LastUpdateMaxSavings { get; set; }
        public double? ExecSavings { get; set; }
        public DateTime? StopDate { get; set; }
    }
}
