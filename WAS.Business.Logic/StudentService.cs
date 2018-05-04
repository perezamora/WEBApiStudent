using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAS.Common.Logic.Logger;
using WAS.Common.Logic.Model;
using WAS.DataAcces.Dao;

namespace WAS.Business.Logic
{
    public class StudentService : IStudentService
    {
        private readonly ILogger _log;
        private IStudentRepository<Student> _studentRepository;

        // Inyectamos el repository por el constructor
        public StudentService(IStudentRepository<Student> studentRepository, ILogger log)
        {
            _log = log;
            _studentRepository = studentRepository;
        }

        public Student Add(Student student)
        {
            throw new NotImplementedException();
        }

        public int DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student Update(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
