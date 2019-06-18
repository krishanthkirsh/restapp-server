using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> List();
        T FindById(int Id);
        void Save();
    }
}
