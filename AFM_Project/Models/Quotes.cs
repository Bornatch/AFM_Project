using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Quotes
    {
        public int IdQuote { get; set; }
        public string Code { get; set; }
        public double? Ask { get; set; }
        public double? Bid { get; set; }
        public double? LastTrade { get; set; }
        public double? ClosePrice { get; set; }
        public DateTime? QuoteDateTime { get; set; }
        public string CompanyName { get; set; }
        public int? Exchange { get; set; }
    }
}
