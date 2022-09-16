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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.NameSurname).IsRequired().HasMaxLength(70);
            builder.Property(c => c.MailAddress).IsRequired().HasMaxLength(100);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(13);

        }
    }
}
