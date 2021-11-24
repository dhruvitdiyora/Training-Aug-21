using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int OfferId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal NetAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerAddressId { get; set; }
        public int CustomerId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerAddress CustomerAddress { get; set; }
        public virtual Offer Offer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
