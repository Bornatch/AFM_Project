using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class QuotesDaily
    {
        public int IdQuote { get; set; }
        public string Code { get; set; }
        public double? Ask { get; set; }
        public double? Bid { get; set; }
        public double? LastTrade { get; set; }
        public DateTime? QuoteDateTime { get; set; }
    }
}
