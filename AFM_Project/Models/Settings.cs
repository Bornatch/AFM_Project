using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Settings
    {
        public int? OrderScanInterval { get; set; }
        public int? CheckCmetInterval { get; set; }
        public int? SodStarthour { get; set; }
        public int? EodStarthour { get; set; }
        public bool? Pause { get; set; }
    }
}
