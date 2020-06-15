using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class IndexMembers
    {
        public int IdIndexmembers { get; set; }
        public int? IdIndex { get; set; }
        public int? IdSecurity { get; set; }
        public string Security { get; set; }
        public double? Weight { get; set; }
    }
}
