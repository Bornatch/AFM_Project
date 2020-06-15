using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class ParamList
    {
        public int IdParamList { get; set; }
        public int? IdParamSinglevalue { get; set; }
        public string ValuesList { get; set; }
        public int? CurPos { get; set; }
        public int? CountPos { get; set; }
        public int? TypeEnum { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public double? StepValue { get; set; }
    }
}
