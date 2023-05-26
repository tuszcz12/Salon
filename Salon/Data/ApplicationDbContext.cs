using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Salon.Models;

namespace Salon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<ConsentForm> ConsentForms { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ConsentForm>()
                .HasOne(c => c.Customer)
                .WithMany()
                .HasForeignKey(c => c.CustomerID);

            modelBuilder.Entity<ConsentForm>()
                .HasOne(c => c.Treatment)
                .WithMany()
                .HasForeignKey(c => c.TreatmentID);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Customer)
                .WithMany()
                .HasForeignKey(a => a.CustomerID);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Treatment)
                .WithMany()
                .HasForeignKey(a => a.TreatmentID);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Employee)
                .WithMany()
                .HasForeignKey(a => a.EmployeeID);

            modelBuilder.Entity<Treatment>()
                .Property(t => t.Price)
                .HasColumnType("decimal(8,2)");
        }
    }
}