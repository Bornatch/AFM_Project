using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class NewTradebuy
    {
        public int Id { get; set; }
        public Guid IdNewtradebuy { get; set; }
        public string Buy { get; set; }
        public double? Bquote { get; set; }
        public int? Bquantity { get; set; }
        public double? SavePercent { get; set; }
        public Guid? IdNewtrade { get; set; }
        public double? Dividend { get; set; }
        public double? Split { get; set; }
        public double? CurSavingAmount { get; set; }
        public DateTime? CurSavingTimeStamp { get; set; }
        public double? OldSavingAmount { get; set; }
        public DateTime? OldSavingTimeStamp { get; set; }
    }
}
