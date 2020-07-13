using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class ClaimUser
    {
        public Guid ClaimId { get; set; }
        public Guid? IdCustomer { get; set; }
        public string ClaimType { get; set; }
        public bool? ClaimValue { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
    }
}
