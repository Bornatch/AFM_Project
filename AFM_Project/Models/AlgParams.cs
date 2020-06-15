using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class AlgParams
    {
        public int IdAlgparam { get; set; }
        public Guid? IdCustomer { get; set; }
        public Guid? IdPhaseOrAlgo { get; set; }
        public int? ParamScope { get; set; }
        public string ParamName { get; set; }
        public int? ParamType { get; set; }
        public double? ParamDoubleValue { get; set; }
        public string ParamStringValue { get; set; }
        public int? ParamIntValue { get; set; }
        public bool? ParamBoolValue { get; set; }
    }
}
