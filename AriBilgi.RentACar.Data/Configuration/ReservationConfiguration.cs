using AriBilgi.RentACar.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.RentACar.Data.Configuration
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.Property(r => r.CarId).IsRequired();
            builder.Property(r => r.CustomerId).IsRequired();
            builder.Property(r => r.StartDate).IsRequired();
            builder.Property(r => r.FinishDate).IsRequired();

           
        }
    }
}
