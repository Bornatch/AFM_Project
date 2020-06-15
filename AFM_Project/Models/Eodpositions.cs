using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Eodpositions
    {
        public int Id { get; set; }
        public Guid? IdCustomer { get; set; }
        public DateTime? DateStamp { get; set; }
        public string Security { get; set; }
        public int? Quantity { get; set; }
        public double? LastTrade { get; set; }
    }
}
