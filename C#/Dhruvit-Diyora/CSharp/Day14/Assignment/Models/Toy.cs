using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14.Models
{
    public partial class Toy
    {
        public Toy()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int ToyId { get; set; }
        public string ToyName { get; set; }
        public decimal Price { get; set; }
        public int ToyPlantId { get; set; }
        public int ToyTypeId { get; set; }
        public bool? IsActive { get; set; }

        public virtual ToyPlant ToyPlant { get; set; }
        public virtual ToyType ToyType { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
