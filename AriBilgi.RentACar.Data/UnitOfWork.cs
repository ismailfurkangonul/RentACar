using AriBilgi.RentACar.Data.Abstract;
using AriBilgi.RentACar.Data.Contexts;
using AriBilgi.RentACar.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.RentACar.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RentContext _context;
        private readonly CustomerRepository _customerRepository;
        private readonly ReservationRepository _reservationRepository;
        private readonly CarRepository _carRepository;

        public UnitOfWork()
        {
            _context = new RentContext();   
        }

        public ICustomerRepository Customers => _customerRepository ?? new CustomerRepository(_context);

        public IReservationRepository Reservations => _reservationRepository ?? new ReservationRepository(_context);

        public ICarRepository Car => _carRepository ?? new CarRepository(_context);
    }
}
