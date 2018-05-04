using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAS.Common.Logic.Model
{
    public class Student
    {
        #region Public Attributes
        public int Id;
        public string Name;
        public string Apellidos;
        public string Dni;
        public DateTime FechaNacimiento;
        public int Edad;
        public DateTime FechaCreacion;
        #endregion

        #region Public Method
        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return student != null &&
                   Id == student.Id &&
                   Name == student.Name &&
                   Apellidos == student.Apellidos &&
                   Dni == student.Dni &&
                   FechaNacimiento == student.FechaNacimiento &&
                   Edad == student.Edad &&
                   FechaCreacion == student.FechaCreacion;
        }

        public override int GetHashCode()
        {
            var hashCode = 567718528;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            hashCode = hashCode * -1521134295 + FechaNacimiento.GetHashCode();
            hashCode = hashCode * -1521134295 + Edad.GetHashCode();
            hashCode = hashCode * -1521134295 + FechaCreacion.GetHashCode();
            return hashCode;
        }
        #endregion
    }
}
