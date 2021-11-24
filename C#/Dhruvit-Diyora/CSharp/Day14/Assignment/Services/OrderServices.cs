using Day14.IServices;
using Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly ToysAPIContext _context;
        public OrderServices(ToysAPIContext context)
        {
            _context = context;
        }
        public Order AddOrder(Order order)
        {
            foreach (OrderItem item in order.OrderItems)
            {
                _context.OrderItems.Add(
                    new OrderItem {
                        ToyId=item.ToyId,
                        Quantity=item.Quantity,
                        OrderId=order.OrderId,
                        IsActive=true
                    });
            }
            var result = _context.Orders.Add(order);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
