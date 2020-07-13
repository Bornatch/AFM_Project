using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Customer
    {
        public Customer()
        {
            //ClaimUser = new HashSet<ClaimUser>();
            Messengers = new HashSet<Messengers>();
            Portfolio = new HashSet<Portfolio>();
            SmartLimit = new HashSet<SmartLimit>();
        }

        public Guid IdCustomer { get; set; }
        public string UserName { get; set; }
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
        public bool? ShareInfoOk { get; set; }
        public bool? PowerUser { get; set; }
        public Guid? IdMetaCustomer { get; set; }
        public int? IdBroker { get; set; }
        public string Account { get; set; }
        public string AccountNick { get; set; }
        public int? TradeLevel { get; set; }
        public int? CommissionType { get; set; }
        public Guid? IdAlgorithmSlow { get; set; }
        public Guid? IdAlgorithmFast { get; set; }
        public Guid? IdAlgorithmCheckauto { get; set; }
        public bool? CanUseCash { get; set; }
        public bool? UseCash { get; set; }
        public string StartupPage { get; set; }

        public virtual ICollection<ClaimUser> ClaimUser { get; set; }
        public virtual ICollection<Messengers> Messengers { get; set; }
        public virtual ICollection<Portfolio> Portfolio { get; set; }
        public virtual ICollection<SmartLimit> SmartLimit { get; set; }
    }
}
