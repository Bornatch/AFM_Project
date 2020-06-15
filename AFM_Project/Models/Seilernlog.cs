using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Seilernlog
    {
        public int IdSeilernlog { get; set; }
        public string Message { get; set; }
        public DateTime? Logdate { get; set; }
    }
}
