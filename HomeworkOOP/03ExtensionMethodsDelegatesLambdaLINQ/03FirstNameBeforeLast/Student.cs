using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03FirstNameBeforeLast
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
    }
}