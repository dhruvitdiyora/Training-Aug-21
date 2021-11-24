using Day14.IServices;
using Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ToysAPIContext _context;
        public CustomerServices(ToysAPIContext context)
        {
            _context = context;
        }
        public Customer AddCustomer(Customer customer)
        {
            var result = _context.Customers.Add(customer);
            _context.SaveChanges();
            return result.Entity;
        }

        public bool DeleteCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            if (customer != null)
            {
                customer.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EditCustomer(Customer customer)
        {
            var dCustomer = _context.Customers.Find(customer.CustomerId);
            if (dCustomer != null)
            {
                dCustomer.FirstName = customer.FirstName;
                dCustomer.LastName = customer.LastName;
                dCustomer.MobileNumber = customer.MobileNumber;
                dCustomer.UserName = customer.UserName;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Customer Get(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            return customer;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
