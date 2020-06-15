using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Eodindexes
    {
        public int Id { get; set; }
        public DateTime? DateStamp { get; set; }
        public double? Djia { get; set; }
        public double? Compx { get; set; }
        public double? Spx { get; set; }
        public double? Dtx { get; set; }
        public double? Rut { get; set; }
        public double? Dux { get; set; }
        public double? Ecm { get; set; }
        public double? Rlx { get; set; }
    }
}
