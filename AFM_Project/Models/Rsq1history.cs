using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Rsq1history
    {
        public Guid IdRsq1 { get; set; }
        public Guid? IdCustomer { get; set; }
        public Guid? IdPool { get; set; }
        public DateTime? DateTime { get; set; }
        public double? PerfRsq1 { get; set; }
        public double? TaxesRsq1 { get; set; }
    }
}
