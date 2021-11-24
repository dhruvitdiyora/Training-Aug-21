using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.Models
{
    public partial class Inventory
    {
        public Inventory()
        {
            Sales = new HashSet<Sale>();
        }

        public int ProductId { get; set; }
        public string ProdName { get; set; }
        public decimal ProdPrice { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
