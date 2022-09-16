using AriBilgi.RentACar.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.RentACar.Shared
{
    public interface IRepository<T>where T:class,IEntity,new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll();
        List<T> GetAll(Func<T,bool>predicate);
        T Get(Func<T, bool> predicate);
        bool IsAny(Func<T, bool> predicate);
        int GetCount(Func<T, bool> predicate);
        int GetCount();
        
    }
}
