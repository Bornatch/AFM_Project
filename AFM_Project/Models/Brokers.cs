using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Brokers
    {
        public int? IdBroker { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
        public bool? AutoExecution { get; set; }
    }
}
