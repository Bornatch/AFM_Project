using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class ParamSetList
    {
        public int IdParamSetList { get; set; }
        public int? IdBatch { get; set; }
        public int IdParamList { get; set; }
        public int? ParamOrder { get; set; }
    }
}
