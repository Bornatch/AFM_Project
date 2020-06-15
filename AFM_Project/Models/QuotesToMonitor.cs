using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class QuotesToMonitor
    {
        public int IdQtm { get; set; }
        public string Security { get; set; }
        public DateTime? Tsadded { get; set; }
    }
}
