using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Portfolio
    {
        public long Id { get; set; }
        public Guid? IdPortfolio { get; set; }
        public Guid IdCustomer { get; set; }
        public int? PortfolioNo { get; set; }
        public string Security { get; set; }
        public int? Quantity { get; set; }
        public string Name { get; set; }
        public double? PurchasedQuote { get; set; }
        public DateTime? PurchasedWhen { get; set; }
        public double? CurQuote { get; set; }
        public DateTime? LastUpdate { get; set; }
        public Guid? IdTraded { get; set; }
        public Guid? IdPool { get; set; }
    }
}
