using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day12.ToyModels
{
    public class Customer
    {

        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MobileNumber { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public Order Orders { get; set; }

        public ICollection<CustomerAddress> CustomerAddress { get; set; }
    }
}
