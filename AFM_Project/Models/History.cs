using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class History
    {
        public Guid IdHistory { get; set; }
        public string Symbol { get; set; }
        public DateTime? CloseDate { get; set; }
    }
}
