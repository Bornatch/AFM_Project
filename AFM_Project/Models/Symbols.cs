using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Symbols
    {
        public int IdSymbol { get; set; }
        public string Code { get; set; }
        public int? Market { get; set; }
        public int? Flag { get; set; }
    }
}
