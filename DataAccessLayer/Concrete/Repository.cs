using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> obj;

        public Repository()
        {
            obj = c.Set<T>();
        }
        public int Add(T p)
        {
            obj.Add(p);
            return c.SaveChanges();
        }

        public int Update(T p)
        {
            obj.Update(p);
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return obj.ToList();
        }

        public int Delete(T p)
        {
            obj.Remove(p);
            return c.SaveChanges();
        }
    }
}
