using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ABCRestaurant.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private RestaurantDBContext _dBConn;
        internal DbSet<T> dbSet;

        public Repository(RestaurantDBContext dBContext)
        {
            this._dBConn = dBContext;
            this.dbSet = dBContext.Set<T>();
        }

        public IQueryable<T> List()
        {
            return dbSet;
        }

        public T FindById(object Id)
        {
            return dbSet.Find(Id);
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            _dBConn.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Save()
        {
            _dBConn.SaveChanges();
        }
    }
}
