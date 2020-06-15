using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class CmetTrackingBuy
    {
        public int IdCmetTrackingBuy { get; set; }
        public int IdCmetTracking { get; set; }
        public string Buy { get; set; }
        public double? Bquote { get; set; }
        public double? CurSavings { get; set; }
        public double? MeanPerf { get; set; }
    }
}
