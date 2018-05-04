using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAS.DataAcces.Dao
{
    public interface ICreateDao<T>
    {
        T Insert(T item);
    }
}
