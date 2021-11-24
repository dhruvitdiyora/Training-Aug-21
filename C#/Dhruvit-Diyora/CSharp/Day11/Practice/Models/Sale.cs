using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.Models
{
    public partial class Sale
    {
        public int SalesId { get; set; }
        public int SalesPerson { get; set; }
        public int ProductId { get; set; }

        public virtual Inventory Product { get; set; }
        public virtual Employee SalesPersonNavigation { get; set; }
    }
}
