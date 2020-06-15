using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Securities
    {
        public int IdSecurity { get; set; }
        public string Security { get; set; }
        public int? IdSector { get; set; }
        public int? IdIndustry { get; set; }
        public int? IdSubindustry { get; set; }
        public string CompanyName { get; set; }
        public double? Volatility { get; set; }
        public double? MarketCap { get; set; }
        public double? VolLowest { get; set; }
        public double? VolAverage { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
