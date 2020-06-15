using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Fixpositions
    {
        public Guid Id { get; set; }
        public Guid? IdCustomer { get; set; }
        public string Security { get; set; }
        public double? BuyValue { get; set; }
        public DateTime? ImportDate { get; set; }
        public bool? Executed { get; set; }
    }
}
