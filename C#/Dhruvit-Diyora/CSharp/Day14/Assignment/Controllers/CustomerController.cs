using Day14.IServices;
using Day14.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;
        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        //get method
        [HttpGet]
        public IActionResult GetCustomers()
        {
            try
            {
                if (_customerServices.GetCustomers() != null)
                {
                    return Ok(_customerServices.GetCustomers());
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{customerId}")]
        public IActionResult GetCustomer(int customerId)
        {
            try
            {
                if (_customerServices.Get(customerId) != null)
                {
                    return Ok(_customerServices.Get(customerId));
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //post method

        [HttpPost()]
        public IActionResult AddCustomer(Customer customer)
        {
            try
            {
                return Ok(_customerServices.AddCustomer(customer));
            }
            catch (Exception)
            {
                throw;
            }
        }


        //put method

        [HttpPut()]
        public IActionResult EditCustomer(Customer customer)
        {
            try
            {
                if (_customerServices.EditCustomer(customer) == true)
                {
                    _customerServices.EditCustomer(customer);
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //delete method

        [HttpDelete("{customerId}")]
        public IActionResult DeleteCustomer(int customerId)
        {
            try
            {
                if (_customerServices.DeleteCustomer(customerId) == true)
                {
                    _customerServices.DeleteCustomer(customerId);
                    return Ok();
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
