using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Secfees
    {
        public Guid IdSecfees { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public double? Fee { get; set; }
    }
}
