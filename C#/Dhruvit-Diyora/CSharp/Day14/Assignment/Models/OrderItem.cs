using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14.Models
{
    public partial class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ToyId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Order Order { get; set; }
        public virtual Toy Toy { get; set; }
    }
}
