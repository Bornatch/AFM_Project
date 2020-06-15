using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class QuotesHistory
    {
        public string Security { get; set; }
        public DateTime QuoteDateTime { get; set; }
        public double? Ask { get; set; }
        public double? Bid { get; set; }
        public double? LastTrade { get; set; }
        public int Id { get; set; }
        public int? Batchno { get; set; }
    }
}
