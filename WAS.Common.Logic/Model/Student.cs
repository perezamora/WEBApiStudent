using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAS.Common.Logic.Model
{
    public class Student
    {
        #region Public Attributes
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime FechaCreacion { get; set; }
        #endregion

        #region Public Method
        public override String ToString() => string.Format("{0};{1};{2};{3};{4};{5};{6};",
                 this.Id, this.Name, this.Apellidos, this.Dni, this.FechaCreacion, this.Edad, this.FechaCreacion);

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
