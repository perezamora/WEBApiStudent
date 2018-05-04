using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAS.Common.Logic.Model
{
    public class StudentContext : DbContext
    {

        public StudentContext() : base("StudentContext")
        {

            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Student> Students { get; set; }

    }
}
