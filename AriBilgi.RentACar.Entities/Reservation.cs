using AriBilgi.RentACar.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.RentACar.Entities
{
    public class Reservation: EntityBase, IEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        
        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}
