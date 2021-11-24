using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day11.Models
{
    public partial class TrainingdemosContext : DbContext
    {
        public TrainingdemosContext()
        {
        }

        public TrainingdemosContext(DbContextOptions<TrainingdemosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobHistory> JobHistories { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;database=Trainingdemos;User ID=dd;Password=12345; persist security info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.RegionId })
                    .HasName("PK__countrie__090503B525869EFC");

                entity.ToTable("countries");

                entity.HasIndex(e => e.CountryName, "UQ__countrie__1E5963E67D33BC00")
                    .IsUnique();

                entity.HasIndex(e => e.CountryId, "UQ__countrie__310271620E83B390")
                    .IsUnique();

                entity.HasIndex(e => e.RegionId, "UQ__countrie__80772D63F9158A15")
                    .IsUnique();

                entity.Property(e => e.CountryId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegionId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REGION_ID");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_NAME");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("departments");

                entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.CommisionPer).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.EmpLastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__inventor__B40CC6CD25E63B56");

                entity.ToTable("inventory");

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPrice).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("jobs");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("JOB_TITLE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MaxSalary)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("MAX_SALARY");

                entity.Property(e => e.MinSalary)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("MIN_SALARY")
                    .HasDefaultValueSql("((8000))");
            });

            modelBuilder.Entity<JobHistory>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__JobHisto__7AD04FF1E190D14A");

                entity.ToTable("JobHistory");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.SalesId)
                    .HasName("PK__sales__C952FB32A25B41B2");

                entity.ToTable("sales");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemId");

                entity.HasOne(d => d.SalesPersonNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.SalesPerson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPerson");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
