//1.We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//  Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have 
//  unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of 
//  exercises. Both teachers and students are people. Students, classes, teachers and disciplines could 
//  have optional comments (free text block).
//  Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate 
//  their fields, define the class hierarchy and create a class diagram with Visual Studio.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01School
{
    class School
    {
        public List<ClassOfStudents> Classes { get; set; }
        
        public School()
        {
            this.Classes = new List<ClassOfStudents>(); ;
        }

        public void AddClass(ClassOfStudents name)
        {
            this.Classes.Add(name);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var course in Classes)
            {
                result.Append(course.ToString());
            }
            return result.ToString();
        }
    }
}
