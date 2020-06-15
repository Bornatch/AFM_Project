using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Algorithm
    {
        public Guid IdAlgorithm { get; set; }
        public string Title { get; set; }
        public bool? IsOnlyAutomatic { get; set; }
        public string BrokerList { get; set; }
        public string ClassName { get; set; }
        public bool? CanUseCash { get; set; }
    }
}
