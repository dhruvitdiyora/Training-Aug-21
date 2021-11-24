using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14.Models
{
    public partial class ToysAPIContext : DbContext
    {
        public ToysAPIContext()
        {
        }

        public ToysAPIContext(DbContextOptions<ToysAPIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ToyPlant> ToyPlants { get; set; }
        public virtual DbSet<ToyType> ToyTypes { get; set; }
        public virtual DbSet<Toy> Toys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=LAPTOP-OPS6N37O\\SQLEXPRESS;database=ToysAPI;User ID=dd;Password=12345; persist security info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.Property(e => e.AddressState)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerAddress1)
                    .IsRequired()
                    .HasColumnName("CustomerAddress")
                    .HasMaxLength(30);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddressCustomer");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__A4AE64D8ABD85797");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.HasKey(e => e.OfferId)
                    .HasName("PK__Offers__8EBCF091699AE7C3");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.PerDiscount).HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemId)
                    .HasName("PK__OrderIte__57ED068191F307A3");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItems_Orders");

                entity.HasOne(d => d.Toy)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ToyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItems_Toys");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BCF8B211BB6");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(4, 2)");

                entity.HasOne(d => d.CustomerAddress)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_CustomerAddress");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Offers");
            });

            modelBuilder.Entity<ToyPlant>(entity =>
            {
                entity.HasKey(e => e.ToyPlantId)
                    .HasName("PK__ToyPlant__261221416A4DC48F");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.PlantAddress)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PlantName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ToyType>(entity =>
            {
                entity.HasKey(e => e.ToyTypeId)
                    .HasName("PK__ToyTypes__516152D9D576B65C");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ToyTypeName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Toy>(entity =>
            {
                entity.HasKey(e => e.ToyId)
                    .HasName("PK__Toys__18774696A4E2B0EF");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Price).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ToyName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.ToyPlant)
                    .WithMany(p => p.Toys)
                    .HasForeignKey(d => d.ToyPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ToyPlants");

                entity.HasOne(d => d.ToyType)
                    .WithMany(p => p.Toys)
                    .HasForeignKey(d => d.ToyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ToyTypes");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
