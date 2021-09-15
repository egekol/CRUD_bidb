using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Class1
    {
        private static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student
                {
                    StudentId = 0,
                    StudentName = "Bill",
                    DateOfBirth = DateTime.Today
                };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
