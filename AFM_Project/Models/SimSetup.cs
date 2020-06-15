using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class SimSetup
    {
        public Guid? IdCustomer { get; set; }
        public Guid? IdAlgoP1 { get; set; }
        public Guid? IdAlgoP2 { get; set; }
        public int? IdBatch { get; set; }
    }
}
