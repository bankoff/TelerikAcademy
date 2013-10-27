using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01School
{
    class Student : Human
    {
        public uint UniqueClassNumber { get; set; }

        public Student(string name, uint uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public Student(string name, uint uniqueClassNumber, string comment)
            : base(name, comment)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public override string ToString()
        {
            string result = "Student: " + this.Name + "   number: " + this.UniqueClassNumber.ToString() + " " + this.Comment;

            return result;
        }
    }
}
