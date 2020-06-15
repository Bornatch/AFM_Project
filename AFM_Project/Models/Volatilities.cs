using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Volatilities
    {
        public Guid IdVolatility { get; set; }
        public string Symbol { get; set; }
        public double? Value { get; set; }
        public DateTime? CloseDate { get; set; }
    }
}
