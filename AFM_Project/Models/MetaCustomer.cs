using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class MetaCustomer
    {
        public MetaCustomer()
        {
            ClaimUser = new HashSet<ClaimUser>();
        }

        public Guid IdMetaCustomer { get; set; }
        public string WebUserName { get; set; }
        public string Password { get; set; }
        public string PasswordHint { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string EMail { get; set; }
        public string SecondMail { get; set; }
        public string ThirdMail { get; set; }
        public string Address { get; set; }
        public string Postal { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneBusiness { get; set; }
        public string PhoneCell { get; set; }
        public string PhoneFax { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public int? Status { get; set; }
        public int? ActiveStatus { get; set; }

        public virtual ICollection<ClaimUser> ClaimUser { get; set; }
    }
}
