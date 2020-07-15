using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Blacklist
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public DateTime RefDate { get; set; }
        public double RefQuote { get; set; }
        public double RefIndex { get; set; }
        public DateTime BeginDate { get; set; }
        public double BeginQuote { get; set; }
        public double BeginIndex { get; set; }
        public DateTime StopDate { get; set; }
        public bool Valid { get; set; }
        public bool? Mandatory { get; set; }
    }
}
