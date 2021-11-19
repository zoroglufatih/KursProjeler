using IleriPersonel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriPersonel.Connection
{
    public static class DbConnection
    {
        static PersonelContext db;
        public static PersonelContext GetConnection()
        {
            if (db == null)
            {
                db = new PersonelContext();
                
            }
            return db;
        }

    }
}
