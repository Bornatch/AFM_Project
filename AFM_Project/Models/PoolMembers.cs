using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class PoolMembers
    {
        public Guid IdPoolMember { get; set; }
        public Guid? IdPool { get; set; }
        public string Security { get; set; }
        public int? Status { get; set; }
        public int? NbShares { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Comment { get; set; }
        public bool? IsInitial { get; set; }
    }
}
