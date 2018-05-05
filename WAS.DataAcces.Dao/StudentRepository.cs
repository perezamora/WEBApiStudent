using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAS.Common.Logic.Logger;
using WAS.Common.Logic.Model;
using WAS.DataAcces.Dao.Exceptions;

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
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var result = 0;
            try
            {
                using (var context = new StudentContext())
                {
                    var student = context.Students
                    .Where(alumno => alumno.Id == id)
                    .FirstOrDefault();

                    context.Students.Remove(student);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new WasDaoException(Resources.LogMessages.errorDelete, e.InnerException);
            }

            return result;
        }

        public List<T> GetAll()
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            List<Student> listaStudents;
            try
            {
                using (var context = new StudentContext())
                {
                    var students = from student in context.Students
                                   select student;

                    listaStudents = students.ToList<Student>();
                }
            }
            catch (Exception e)
            {
                throw new WasDaoException(Resources.LogMessages.errorGetAll, e.InnerException);
            }

            return (List<T>)Convert.ChangeType(listaStudents, typeof(List<T>));
        }

        public T Insert(T item)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var student = item as Student;
            try
            {
                using (var context = new StudentContext())
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new WasDaoException(Resources.LogMessages.errorInsert, e.InnerException);
            }

            return (T)Convert.ChangeType(student, typeof(T));
        }

        public T SelectById(int id)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            Student alumno;
            try
            {
                using (var context = new StudentContext())
                {
                    alumno = context.Students
                   .Where(student => student.Id == id)
                   .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                throw new WasDaoException(Resources.LogMessages.errorSelectById, e.InnerException);
            }

            return (T)Convert.ChangeType(alumno, typeof(T));
        }

        public T Update(int id, T item)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            Student studentUpdate;
            var student = item as Student;
            try
            {
                using (var context = new StudentContext())
                {
                    studentUpdate = context.Students
                                .Where(alumno => alumno.Id == id)
                                .FirstOrDefault();

                    studentUpdate.Name = student.Name;
                    studentUpdate.Apellidos = student.Apellidos;
                    studentUpdate.Dni = student.Dni;
                    studentUpdate.Edad = student.Edad;
                    studentUpdate.FechaNacimiento = student.FechaNacimiento;
                    
                    context.SaveChanges();   
                }
            }
            catch (Exception e)
            {
                throw new WasDaoException(Resources.LogMessages.errorUpdate, e.InnerException);
            }

            return (T)Convert.ChangeType(studentUpdate, typeof(T));
        }
    }
}
