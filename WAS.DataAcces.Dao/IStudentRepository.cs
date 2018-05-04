using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAS.DataAcces.Dao
{
    public interface IStudentRepository<T> : IReadDao<T>, ICreateDao<T>, IDeleteDao<T>, IUpdateDao<T>
    {
    }
}
