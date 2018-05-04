using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAS.Common.Logic.Model;

namespace WAS.Business.Logic
{
    public interface IStudentService
    {
        #region Public Method
        Student Add(Student student);
        Student GetById(int id);
        Student Update(int id, Student student);
        int DeleteById(int id);
        List<Student> GetAll();
        #endregion
    }
}
