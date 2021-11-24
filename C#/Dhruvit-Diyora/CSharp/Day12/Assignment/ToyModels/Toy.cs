using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day12.ToyModels
{
    public class Toy
    {
        [Key]
        public int ToyId { get; set; }
        public string ToyName { get; set; }
        public int ToyPrice { get; set; }
        public int PlantId { get; set; }
        public int ToyTypeId { get; set; }
        public ManuPlant Plants { get; set; }
        public ToyType ToyTypes { get; set; }

        public ICollection<Order> Orders { get; set; }
        public bool IsActive { get; set; }
    }
}
