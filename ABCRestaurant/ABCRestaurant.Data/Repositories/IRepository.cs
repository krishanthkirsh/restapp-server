using System.Linq;

namespace ABCRestaurant.Data.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> List();
        T FindById(object Id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
