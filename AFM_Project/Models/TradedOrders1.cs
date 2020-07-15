using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class TradedOrders1
    {
        public Guid IdTraded { get; set; }
        public Guid? IdNtslmc { get; set; }
        public Guid? IdBuyline { get; set; }
        public DateTime TradedDate { get; set; }
        public int? Status { get; set; }
        public Guid? IdCustomer { get; set; }
        public string Sell { get; set; }
        public string Buy { get; set; }
        public int? Squantity { get; set; }
        public int? Bquantity { get; set; }
        public double? Squote { get; set; }
        public double? Bquote { get; set; }
        public double? OtherAmount { get; set; }
        public double? BrokerCommissionSell { get; set; }
        public double? BrokerCommissionBuy { get; set; }
        public double? Seccommission { get; set; }
        public int Ordertype { get; set; }
        public int? PortfolioNo { get; set; }
        public double? Djia { get; set; }
        public double? Spx { get; set; }
        public double? Compx { get; set; }
        public int? Executor { get; set; }
        public bool? NegSavingL0 { get; set; }
        public bool? NegSavingL1 { get; set; }
        public bool? NegSavingL2 { get; set; }
        public bool? NegSavingL3 { get; set; }
        public bool? StopLoss { get; set; }
        public bool? QuoteNegL1 { get; set; }
        public bool? QuoteNegL2 { get; set; }
        public bool? QuoteNegL3 { get; set; }
        public bool? EarningsSell { get; set; }
        public bool? BlacklistSell { get; set; }
        public double? SavingMinimum { get; set; }
        public double? QuoteMinimum { get; set; }
        public double? SavingMax { get; set; }
        public double? SavingLast { get; set; }
        public double? QuoteMax { get; set; }
        public double? QuoteLast { get; set; }
        public DateTime? SavingMaxDate { get; set; }
        public DateTime? SavingMinDate { get; set; }
        public double? ExecutedSaving { get; set; }
        public int? DaySinceCreation { get; set; }
        public int? ExecutionType { get; set; }
        public double? SavingVsBest { get; set; }
        public string BuyBestSave { get; set; }
        public string BuyWorstSave { get; set; }
        public double? AverageSaving { get; set; }
    }
}
