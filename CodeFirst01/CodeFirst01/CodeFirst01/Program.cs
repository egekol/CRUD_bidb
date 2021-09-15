using System;

namespace CodeFirst01
{
    class Program
    {
        static void Main(string[] args)
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
