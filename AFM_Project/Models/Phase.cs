using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Phase
    {
        public Guid IdPhase { get; set; }
        public int? IdPhasetype { get; set; }
        public string Title { get; set; }
        public string ClassName { get; set; }
    }
}
