using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day12.ToyModels
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public int AddressId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public String ToyIds { get; set; }
        public Customer Customers { get; set; }
        public ICollection<Toy> Toys { get; set; }
    }
}
