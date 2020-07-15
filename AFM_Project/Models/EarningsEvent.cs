using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class EarningsEvent
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string DateWsh { get; set; }
        public string TimeWsh { get; set; }
        public string StatusWsh { get; set; }
        public DateTime SellDate { get; set; }
        public bool Executed { get; set; }
    }
}
