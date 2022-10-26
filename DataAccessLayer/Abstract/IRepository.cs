using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        int Add(T p);
        int Delete(T p);
        int Update(T p);
        List<T> List();
    }
}
