using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Eoddata
    {
        public int Id { get; set; }
        public Guid? IdCustomer { get; set; }
        public DateTime? DateStamp { get; set; }
        public double? Portfolio { get; set; }
        public double? NbShares { get; set; }
        public double? Cash { get; set; }
        public double? CapitalIncrease { get; set; }
        public double? BotSold { get; set; }
    }
}
