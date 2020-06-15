using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class OpenOrdersBrokerToExecute
    {
        public Guid IdBrokerToExecute { get; set; }
        public Guid? IdOrder { get; set; }
        public string Security { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public int? Status { get; set; }
        public int? WhatAction { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? Exchange { get; set; }
        public int ApiorderId { get; set; }
        public int? BrokerOrderId { get; set; }
        public int? OrderType { get; set; }
        public string UserId { get; set; }
        public int? IdBroker { get; set; }
        public int? IbApiorderId { get; set; }
        public int? IbPermId { get; set; }
    }
}
