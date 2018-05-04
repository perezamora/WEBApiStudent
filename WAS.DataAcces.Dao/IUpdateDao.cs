using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAS.DataAcces.Dao
{
    public interface IUpdateDao<T>
    {
        T Update(int id, T item);
    }
}
