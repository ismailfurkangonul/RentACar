using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.RentACar.Data.Abstract
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IReservationRepository Reservations { get; }
        ICarRepository Car { get; }
    }
}
