using AriBilgi.RentACar.Shared.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.RentACar.Shared
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T Get(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate).SingleOrDefault();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> GetAll(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }

        public int GetCount(Func<T, bool> predicate)
        {
            return _context.Set<T>().Count(predicate);
        }

        public int GetCount()
        {
            return _context.Set<T>().Count();
        }

        public bool IsAny(Func<T, bool> predicate)
        {
            return _context.Set<T>().Any(predicate);
        }

        public void Update(T entity)
        {
             _context.Set<T>().Update(entity);
        }
    }

}
