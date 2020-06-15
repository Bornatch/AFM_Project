using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class PoolsAndPoolmembers
    {
        public Guid IdPool { get; set; }
        public Guid IdCustomer { get; set; }
        public string Title { get; set; }
        public int? PoolStatus { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateStopped { get; set; }
        public double? ReqSavings { get; set; }
        public double? PoolSize { get; set; }
        public string Security { get; set; }
        public int? PoolmembersStatus { get; set; }
        public int? NbShares { get; set; }
        public bool? IsInitial { get; set; }
    }
}
