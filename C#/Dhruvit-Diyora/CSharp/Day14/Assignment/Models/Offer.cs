using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14.Models
{
    public partial class Offer
    {
        public Offer()
        {
            Orders = new HashSet<Order>();
        }

        public int OfferId { get; set; }
        public decimal PerDiscount { get; set; }
        public int OrderAmount { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
