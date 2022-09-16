using AriBilgi.RentACar.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.RentACar.Entities
{
    public class Customer:EntityBase, IEntity
    {
        public string NameSurname { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }
}
