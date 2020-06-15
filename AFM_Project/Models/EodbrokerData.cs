using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class EodbrokerData
    {
        public int Id { get; set; }
        public DateTime? Datestamp { get; set; }
        public Guid? IdCustomer { get; set; }
        public double? Portfolio { get; set; }
        public double? CapitalIncrease { get; set; }
        public double? BotSold { get; set; }
        public double? NbShares { get; set; }
        public double? PortfolioSharePrice { get; set; }
        public double? Cash { get; set; }
    }
}
