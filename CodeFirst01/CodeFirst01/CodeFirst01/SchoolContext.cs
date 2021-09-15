using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirst01
{
    class SchoolContext: DbContext
    {

        public SchoolContext() : base("SchoolTestDb")
        {

        }



        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
