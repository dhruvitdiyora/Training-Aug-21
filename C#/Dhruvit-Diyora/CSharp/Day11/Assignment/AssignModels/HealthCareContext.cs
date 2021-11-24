using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day11.AssignModels
{
    public partial class HealthCareContext : DbContext
    {
        public HealthCareContext()
        {
        }

        public HealthCareContext(DbContextOptions<HealthCareContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assistant> Assistants { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<MedicineTime> MedicineTimes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Prescribed> Prescribeds { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=LAPTOP-OPS6N37O\\SQLEXPRESS;database=HealthCare;User ID=dd;Password=12345; persist security info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Assistant>(entity =>
            {
                entity.ToTable("Assistant");

                entity.Property(e => e.AssistantFirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.AssistantLastName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AssistDepartment)
                    .WithMany(p => p.Assistants)
                    .HasForeignKey(d => d.AssistDepartmentId)
                    .HasConstraintName("FK_AssistDept");

                entity.HasOne(d => d.AssistDoctor)
                    .WithMany(p => p.Assistants)
                    .HasForeignKey(d => d.AssistDoctorId)
                    .HasConstraintName("FK_AssistDocor");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("Doctor");

                entity.Property(e => e.DoctorFirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DoctorLastName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.DocDepartment)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.DocDepartmentId)
                    .HasConstraintName("FK_DocorDept");
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MedicineName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<MedicineTime>(entity =>
            {
                entity.ToTable("MedicineTime");

                entity.Property(e => e.InMorning).HasDefaultValueSql("((0))");

                entity.Property(e => e.InNight).HasDefaultValueSql("((0))");

                entity.Property(e => e.InNoon).HasDefaultValueSql("((0))");

                entity.Property(e => e.MedicineTake)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.MedicineTimes)
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicineTime");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.HasIndex(e => e.MobileNo, "UQ__Patient__D6D73A86F4FABB71")
                    .IsUnique();

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.PatientFirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PatientLastName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Prescribed>(entity =>
            {
                entity.ToTable("Prescribed");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MedicineTimeId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrescibedDate).HasColumnType("date");

                entity.HasOne(d => d.Treatment)
                    .WithMany(p => p.Prescribeds)
                    .HasForeignKey(d => d.TreatmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TreatPrescribed");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.ToTable("Treatment");

                entity.Property(e => e.AdmitDate).HasColumnType("date");

                entity.Property(e => e.AssistantId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DischargeDate).HasColumnType("date");

                entity.Property(e => e.DiseaseName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TreatDoctor");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TreatPatient");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
