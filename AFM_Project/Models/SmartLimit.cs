using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class SmartLimit
    {
        public Guid IdSmartlimit { get; set; }
        public short? Action { get; set; }
        public string Symbol { get; set; }
        public int? Quantity { get; set; }
        public short? Performs { get; set; }
        public string Index { get; set; }
        public double? Rate { get; set; }
        public double? QuoteValue { get; set; }
        public double? MarketValue { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public short? AdviseSecondMail { get; set; }
        public short? AdviseThirdMail { get; set; }
        public double? Cost { get; set; }
        public short? Status { get; set; }
        public Guid? IdCustomer { get; set; }
        public int? IdSeilern { get; set; }
        public double? CurSavingAmount { get; set; }
        public DateTime? CurSavingTimeStamp { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
    }
}
