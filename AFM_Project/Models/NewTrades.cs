using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class NewTrades
    {
        public Guid IdNewtrade { get; set; }
        public string Sell { get; set; }
        public double? Squote { get; set; }
        public int? Squantity { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public short? AdviseSecondMail { get; set; }
        public short? AdviseThirdMail { get; set; }
        public double? Cost { get; set; }
        public short? Status { get; set; }
        public Guid? IdCustomer { get; set; }
        public double? Dividend { get; set; }
        public double? Split { get; set; }
        public int? IdSeilern { get; set; }
        public int? DoReverse { get; set; }
        public Guid? IdPool { get; set; }
        public double? Djia { get; set; }
        public double? Spx { get; set; }
        public double? Compx { get; set; }
        public bool? SellExecuted { get; set; }
        public bool? BuyExecuted { get; set; }
        public int? ExecutionStatus { get; set; }
    }
}
