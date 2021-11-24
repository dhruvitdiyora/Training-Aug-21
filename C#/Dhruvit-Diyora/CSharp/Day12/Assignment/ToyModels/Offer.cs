using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day12.ToyModels
{
    public class Offer
    {
        [Key]
        public int OfferId { get; set; }
        public decimal Percentage { get; set; }
        public int OrderAmount { get; set; }
        public Order Orders { get; set; }
    }
}
