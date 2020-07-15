using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Sp500
    {
        public Guid Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string GicsSector { get; set; }
        public string GicsSubsector { get; set; }
        public double? MarketCap { get; set; }
        public double? Weight { get; set; }
        public DateTime? Updated { get; set; }
        public double? Beta { get; set; }
        public long? FloatShares { get; set; }
        public double? Eps { get; set; }
    }
}
