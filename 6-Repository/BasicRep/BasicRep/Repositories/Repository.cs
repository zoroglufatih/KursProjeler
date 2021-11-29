using BasicRep.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRep.Repositories
{
    public class Repository<T> where T:class
    {
        PerDbEntities db = new PerDbEntities();
        public void Sil(T ent)
        {
            Set().Remove(ent);
        }
        public void Ekle(T ent)
        {
            Set().Add(ent);
        }
        public void Kaydet()
        {
            db.SaveChanges();
        }
        public void Guncelle()
        {
            Kaydet();
        }
        public T Bul(int id)
        {
            return Set().Find(id);
        }
        public List<T> Liste()
        {
            return Set().ToList();
        }
        public DbSet<T> Set()
        {
            return db.Set<T>();
        }
        public IQueryable<T> Qry()
        {
            return Set().AsQueryable();
        }
    }
}
