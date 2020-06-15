using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Messages
    {
        public int IdMessage { get; set; }
        public string Recipient { get; set; }
        public string Body { get; set; }
        public DateTime? Sent { get; set; }
        public int? Status { get; set; }
    }
}
