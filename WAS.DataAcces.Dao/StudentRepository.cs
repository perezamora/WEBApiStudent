using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAS.Common.Logic.Logger;

namespace WAS.DataAcces.Dao
{
    public class StudentRepository<T> : IStudentRepository<T>
    {
        private ILogger _log;

        public StudentRepository(ILogger log)
        {
            _log = log;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Insert(T item)
        {
            throw new NotImplementedException();
        }

        public T SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(int id, T item)
        {
            throw new NotImplementedException();
        }
    }
}
