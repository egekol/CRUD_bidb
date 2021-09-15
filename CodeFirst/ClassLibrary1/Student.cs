using System;

namespace ClassLibrary1
{
    public class Student
    {
        public int  StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; } 
        public Grade Grade { get; set; }
    }
}