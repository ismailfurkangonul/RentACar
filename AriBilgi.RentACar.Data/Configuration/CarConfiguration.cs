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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(cr => cr.Brand).IsRequired().HasMaxLength(70);
            builder.Property(cr => cr.Model).IsRequired().HasMaxLength(70);
            builder.Property(cr => cr.FuelType).IsRequired().HasMaxLength(20);

        }
    }
}
