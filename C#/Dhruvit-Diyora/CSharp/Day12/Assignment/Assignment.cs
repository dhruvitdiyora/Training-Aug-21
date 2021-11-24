using Day12.ToyModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day12
{
    public class Assignment
    {
        static void Main(string[] args)
        {
            using (var context = new ToysContext())
            {
                Console.WriteLine("Please select from below!!");
                int choice;
                int exitiing = 1;
                while (exitiing == 1)
                {
                    Console.WriteLine("1.Add Customer\n" +
                                      "2.Remove Customer\n" +
                                      "3.Update Customer\n" +
                                      "4.Show Toys\n" +
                                      "5.Show Offers\n" +
                                      "6.Place an Order\n" +
                                      "7.Search Toys\n" +
                                      "8.Search Order\n" +
                                      "9.Exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter firstname:");
                            string custfname = Console.ReadLine();
                            Console.WriteLine("Enter lastname:");
                            string custlname = Console.ReadLine();
                            Console.WriteLine("Enter mobile:");
                            int custphone = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter username:");
                            string userName = Console.ReadLine();
                            var customer = new Customer()
                            {
                                FirstName = custfname,
                                LastName = custlname,
                                MobileNumber = custphone,
                                UserName=userName,
                            };
                            context.Customers.Add(customer);
                            context.SaveChanges();
                            break;
                        case 2:
                            Console.WriteLine("Enter customerId to remove");
                            int custId = Convert.ToInt32(Console.ReadLine());
                            var customerRemove = context.Customers.Find(custId);
                            //null exception
                            customerRemove.IsActive = false;
                            context.SaveChanges();
                            break;
                        case 3:
                            Console.WriteLine("Enter customerId to edit");
                            int editCustId = Convert.ToInt32(Console.ReadLine());
                            var editCust = context.Customers.Find(editCustId);
                            Console.WriteLine("Enter firstName:");
                            editCust.FirstName = Console.ReadLine();
                            Console.WriteLine("Enter lastname:");
                            editCust.LastName = Console.ReadLine();
                            Console.WriteLine("Enter mobile:");
                            editCust.MobileNumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter username:");
                            editCust.UserName= Console.ReadLine();
                            context.SaveChanges();
                            break;
                        case 4:
                            Console.WriteLine("Showing Products");
                            var products = context.Toys.FromSqlRaw($"EXEC GetProducts").ToList();
                            var productActive = products.Where(p => p.IsActive = true).ToList();
                            foreach (var product in productActive)
                            {
                                Console.WriteLine($"ToyId : {product.ToyId},Toy : {product.ToyName}, Price : {product.ToyPrice}, Plant : {product.Plants} \n");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Showing Offers");
                            var offers = context.Offers.ToList();
                            foreach (var offer in offers)
                            {
                                Console.WriteLine($"This is offer that if you buy of total : {offer.OrderAmount}, then you'll get discount of  : {offer.Percentage}% on total bill\n");
                            }
                            break;
                        case 6:
                            int OrdId = context.Orders.Count() + 1;
                            Console.WriteLine("Enter addressId:");
                            int orderaAddId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter customerId:");
                            int customerId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter toysId:");
                            string toysId = Console.ReadLine();
                            var order = new Order()
                            {
                                AddressId = orderaAddId,
                                OrderDate = DateTime.Today,
                                CustomerId= customerId,
                                ToyIds=toysId 

                            };
                            context.Orders.Add(order);
                            
                            
                            break;
                        case 7:
                            Console.WriteLine("Enter ToyId:");
                            int toyId = Convert.ToInt32(Console.ReadLine());
                            var searchToy = context.Toys.Find(toyId);
                            Console.WriteLine($"ToyId : {searchToy.ToyId},ToyName : {searchToy.ToyName},Price : {searchToy.ToyPrice},plant name  : {searchToy.Plants.PlantName},{searchToy.Plants.Address}");
                            break;
                        case 8:
                            Console.WriteLine("Enter orderId:");
                            int orderId = Convert.ToInt32(Console.ReadLine());
                            var orderDet = context.Orders.Find(orderId);
                            Console.WriteLine($"Order : {orderDet.OrderId},Amount : {orderDet.TotalAmount}");
                            break;
                        case 9:
                            exitiing = 0;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice!");
                            break;
                    }
                }
                context.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}