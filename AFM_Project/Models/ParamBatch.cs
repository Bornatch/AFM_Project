using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class ParamBatch
    {
        public int IdBatch { get; set; }
        public string Title { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? CountCombinations { get; set; }
        public int? CurCombination { get; set; }
    }
}
