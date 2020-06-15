using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class QuotesEvent
    {
        public int Id { get; set; }
        public DateTime? EventDate { get; set; }
        public string Security { get; set; }
        public int? EventType { get; set; }
        public double? Factor { get; set; }
        public bool? OrderAdjusted { get; set; }
    }
}
