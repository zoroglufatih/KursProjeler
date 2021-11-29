using IleriRepository.Context;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        PerContext db = new PerContext();
        public bool Add(T entity)
        {
            try
            {
                Set().Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                Set().Remove(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Find(int id)
        {
            return Set().Find(id);
        }
        public T Find(string id)
        {
            return Set().Find(id);
        }
        public T Find(int key1, int key2)
        {
            return Set().Find(key1,key2);
        }
        public List<T> List()
        {
            return Set().ToList();
        }

        public DbSet<T> Set()
        {
            return db.Set<T>();
        }

        public void Update()
        {
            db.SaveChanges();
        }
    }
}
