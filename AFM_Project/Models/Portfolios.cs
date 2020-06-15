using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Portfolios
    {
        public int IdPortfolioNo { get; set; }
        public Guid? IdCustomer { get; set; }
        public int? Number { get; set; }
        public string Title { get; set; }
    }
}
