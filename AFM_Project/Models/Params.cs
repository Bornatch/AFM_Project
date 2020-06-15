using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Params
    {
        public int IdParam { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TypeValue { get; set; }
        public int? TypeAttach { get; set; }
        public Guid? IdAttach { get; set; }
    }
}
