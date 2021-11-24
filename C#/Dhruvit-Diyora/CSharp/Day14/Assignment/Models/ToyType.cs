using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14.Models
{
    public partial class ToyType
    {
        public ToyType()
        {
            Toys = new HashSet<Toy>();
        }

        public int ToyTypeId { get; set; }
        public string ToyTypeName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Toy> Toys { get; set; }
    }
}
