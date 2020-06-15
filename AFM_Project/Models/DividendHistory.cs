using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class DividendHistory
    {
        public Guid? IdDividendHistory { get; set; }
        public Guid? IdCustomer { get; set; }
        public DateTime? ExDate { get; set; }
        public string Security { get; set; }
        public int? Quantity { get; set; }
        public double? ValueAction { get; set; }
        public double? ValueAll { get; set; }
    }
}
