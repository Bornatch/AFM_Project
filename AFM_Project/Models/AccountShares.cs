using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class AccountShares
    {
        public int IdAccountShares { get; set; }
        public Guid? IdCustomer { get; set; }
        public DateTime? DateStamp { get; set; }
        public double? Portfolio { get; set; }
        public double? CapitalIncrease { get; set; }
        public double? BotSold { get; set; }
        public double? NbShares { get; set; }
        public int? CustomerType { get; set; }
        public bool? CustomerIsBrokerData { get; set; }
    }
}
