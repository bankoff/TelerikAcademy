using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05SortStudents
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            string student = "Student First Name: " + this.FirstName + "     Last Name: " + this.LastName;
            return student;
        }
    }
}
