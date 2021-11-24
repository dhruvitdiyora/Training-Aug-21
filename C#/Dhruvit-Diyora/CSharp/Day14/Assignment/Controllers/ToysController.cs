using Day14.IServices;
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
    public class ToysController : ControllerBase
    {
        private readonly IToyServices _toyServices;
        public ToysController(IToyServices toyServices)
        {
            _toyServices = toyServices;
        }
        [HttpGet]
        public IActionResult GetToys()
        {
            try
            {
                if (_toyServices.GetToys() != null)
                {
                    return Ok(_toyServices.GetToys());
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

        [HttpGet("{toyId}")]
        public IActionResult GetToy(int toyId)
        {
            try
            {
                if (_toyServices.GetToy(toyId) != null)
                {
                    return Ok(_toyServices.GetToy(toyId));
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
