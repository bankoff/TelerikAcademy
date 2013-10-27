using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Human
{
    public class Student : Human
    {
        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return "Student - Name: " + this.FirstName + " " + this.LastName + "   Grade: " + this.Grade;
        }
    }
}
