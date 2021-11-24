using Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14.IServices
{
    public interface IOrderServices
    {
        Order AddOrder(Order order);
    }
}
