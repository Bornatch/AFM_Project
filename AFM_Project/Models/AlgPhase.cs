using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class AlgPhase
    {
        public Guid IdAlgorithm { get; set; }
        public Guid IdPhase { get; set; }
        public DateTime? DateStamp { get; set; }
        public string Comment { get; set; }
        public int? Pos { get; set; }
    }
}
