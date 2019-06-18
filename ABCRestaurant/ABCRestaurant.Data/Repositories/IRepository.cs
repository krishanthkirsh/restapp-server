using System.Collections.Generic;

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
