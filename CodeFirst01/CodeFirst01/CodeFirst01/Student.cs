using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst01
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Grade Grade { get; set; }
    }
}
