using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class ParamSingleValue
    {
        public int IdParamSinglevalue { get; set; }
        public int? IdParam { get; set; }
        public Guid? IdCustomer { get; set; }
        public int? ValueInt { get; set; }
        public string ValueString { get; set; }
        public bool? ValueBool { get; set; }
        public double? ValueDouble { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
