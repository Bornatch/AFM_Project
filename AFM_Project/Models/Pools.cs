using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Pools
    {
        public Guid IdPool { get; set; }
        public Guid IdCustomer { get; set; }
        public string Title { get; set; }
        public int? Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateStopped { get; set; }
        public DateTime? LastUpdatePool { get; set; }
        public double? ReqSavings { get; set; }
        public double? PerfRsq1 { get; set; }
        public double? TaxesRsq1 { get; set; }
        public double? PoolSize { get; set; }
        public int? IdSector { get; set; }
        public double? ExtraValue { get; set; }
    }
}
