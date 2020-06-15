using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class TradedOrders
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
    }
}
