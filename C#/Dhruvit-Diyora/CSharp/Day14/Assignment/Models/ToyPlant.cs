using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14.Models
{
    public partial class ToyPlant
    {
        public ToyPlant()
        {
            Toys = new HashSet<Toy>();
        }

        public int ToyPlantId { get; set; }
        public string PlantName { get; set; }
        public string PlantAddress { get; set; }
        public int Pincode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Toy> Toys { get; set; }
    }
}
