using Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14.IServices
{
    public interface ICustomerServices
    {
        IEnumerable<Customer> GetCustomers();
        Customer Get(int customerId);
        Customer AddCustomer(Customer customer);
        bool EditCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
    }
}
