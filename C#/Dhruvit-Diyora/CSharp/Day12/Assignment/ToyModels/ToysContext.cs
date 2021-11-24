using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day12.ToyModels
{
    public class ToysContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;database=Toys;User ID=dd;Password=12345; persist security info=True;");

        }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<ToyType> ToyTypes { get; set; }
        public DbSet<ManuPlant> Plants { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne<Order>(s => s.Orders)
                .WithOne(ad => ad.Customers)
                .HasForeignKey<Order>(ad => ad.CustomerId);

            modelBuilder.Entity<CustomerAddress>()
                .HasOne<Customer>(s => s.Customers)
                .WithMany(g => g.CustomerAddress)
                .HasForeignKey(s => s.CustomerId);
        }
    }
}
