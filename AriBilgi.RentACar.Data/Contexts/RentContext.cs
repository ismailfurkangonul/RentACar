using AriBilgi.RentACar.Data.Configuration;
using AriBilgi.RentACar.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.RentACar.Data.Contexts
{
    public class RentContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Reservation>Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=PC\\SQLEXPRESS;Database=RentACar;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new CarConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
