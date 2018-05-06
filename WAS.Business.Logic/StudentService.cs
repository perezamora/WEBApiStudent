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
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + student.ToString());
            student.Edad = this.CalcularEdat(student.FechaNacimiento);
            student.FechaCreacion = this.CalcularDateCreate();
            return _studentRepository.Insert(student);
        }

        public int DeleteById(int id)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + id);
            return _studentRepository.Delete(id);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public Student GetById(int id)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + id);
            return _studentRepository.SelectById(id);
        }

        public Student Update(int id, Student student)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + student.ToString());
            student.Edad = this.CalcularEdat(student.FechaNacimiento);
            return _studentRepository.Update(id, student);
        }


        public int CalcularEdat(DateTime fechaNacimiento)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            DateTime CurrentDate = DateTime.Now;
            var edad = CurrentDate.Year - fechaNacimiento.Year;
            if (CurrentDate.Month < fechaNacimiento.Month || (CurrentDate.Month == fechaNacimiento.Month && CurrentDate.Day < fechaNacimiento.Day))
                edad--;
            return edad;
        }

        private DateTime CalcularDateCreate()
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            return DateTime.Now;
        }
    }
}
