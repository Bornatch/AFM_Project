using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class CmetTracking
    {
        public int IdCmetTracking { get; set; }
        public Guid? IdCmetConditions { get; set; }
        public DateTime? DateStamp { get; set; }
        public double? CurSavings { get; set; }
        public double? ExecSavings { get; set; }
        public string Sell { get; set; }
        public double? Squote { get; set; }
        public string Buy { get; set; }
        public double? Bquote { get; set; }
        public double? MeanPerf { get; set; }
    }
}
