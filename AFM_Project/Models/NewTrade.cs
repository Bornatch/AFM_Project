﻿using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class NewTrade
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
        public bool? NegSavingL1 { get; set; }
        public bool? NegSavingL2 { get; set; }
        public bool? NegSavingL0 { get; set; }
        public bool? NegSavingL3 { get; set; }
        public DateTime? NegSavL0time { get; set; }
        public bool? StopLoss { get; set; }
        public bool? QuoteNegL1 { get; set; }
        public bool? QuoteNegL2 { get; set; }
        public bool? QuoteNegL3 { get; set; }
        public bool? EarningsSell { get; set; }
        public int? NbResch { get; set; }
        public double? InitSquote { get; set; }
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
