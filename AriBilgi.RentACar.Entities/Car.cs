using AriBilgi.RentACar.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.RentACar.Entities
{
    public class Car: EntityBase, IEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public ICollection<Reservation> Reservations { get; set; }


    }

}
