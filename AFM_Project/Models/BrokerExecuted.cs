using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class BrokerExecuted
    {
        public int IdBrokerExecuted { get; set; }
        public Guid? IdBrokerToExecute { get; set; }
        public string Security { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public DateTime? DateStamp { get; set; }
        public int? Custom1 { get; set; }
        public int? ApiorderId { get; set; }
        public string ActionPerformed { get; set; }
        public int? IbPermId { get; set; }
    }
}
