using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class ReverseOrders
    {
        public Guid ParentId { get; set; }
        public Guid ChildId { get; set; }
    }
}
