using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Paiment
    {
        public Guid IdPaiment { get; set; }
        public DateTime? DatePaiment { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiration { get; set; }
        public double? Amount { get; set; }
        public Guid? IdCustomer { get; set; }
    }
}
