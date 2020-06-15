using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class ExecutedOrders
    {
        public Guid IdOrder { get; set; }
        public Guid? IdBuyline { get; set; }
        public DateTime ExecutionDate { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public int Which { get; set; }
        public double? Djia { get; set; }
        public double? Spx { get; set; }
        public double? Compx { get; set; }
    }
}
