using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Messengers
    {
        public Guid IdMessenger { get; set; }
        public short? MessengerType { get; set; }
        public string MessengerId { get; set; }
        public Guid? IdCustomer { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
    }
}
