using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14.Models
{
    public partial class CustomerAddress
    {
        public CustomerAddress()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerAddressId { get; set; }
        public string CustomerAddress1 { get; set; }
        public string City { get; set; }
        public string AddressState { get; set; }
        public string Country { get; set; }
        public int CustomerId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
