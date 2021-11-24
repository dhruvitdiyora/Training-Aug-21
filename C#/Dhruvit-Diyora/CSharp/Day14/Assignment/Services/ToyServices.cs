using Day14.IServices;
using Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14.Services
{
    public class ToyServices: IToyServices
    {
        private readonly ToysAPIContext _context;
        public ToyServices(ToysAPIContext context)
        {
            _context = context;
        }

        public Toy GetToy(int toyId)
        {
            var toy = _context.Toys.Find(toyId);
            return toy;
        }

        public IEnumerable<Toy> GetToys()
        {
            return _context.Toys.ToList();
        }
    }
}
