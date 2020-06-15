using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class PortfolioHistory
    {
        public int IdHistory { get; set; }
        public Guid? IdCustomer { get; set; }
        public DateTime? DateTime { get; set; }
        public double? InitPortfolioTotal { get; set; }
        public double? CurPortfolioTotal { get; set; }
        public double? CurPortfolioCash { get; set; }
        public double? CurDow { get; set; }
        public double? CurSpx { get; set; }
        public double? CurCompx { get; set; }
    }
}
