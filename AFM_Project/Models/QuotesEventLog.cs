using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class QuotesEventLog
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
