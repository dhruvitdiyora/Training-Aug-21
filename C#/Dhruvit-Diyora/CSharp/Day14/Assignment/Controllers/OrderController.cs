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
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderServices;
        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        [HttpPost()]
        public IActionResult PostOrder(Order order)
        {
            try
            {
                return Ok(_orderServices.AddOrder(order));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
