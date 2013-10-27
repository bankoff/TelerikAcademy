using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01School
{
    class ClassOfStudents
    {
        public string ClassIdentifier { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
        public string Comments { get; set; }

        public ClassOfStudents(string classIdentifier)
        {
            this.ClassIdentifier = classIdentifier;
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }

        public ClassOfStudents(string classIdentifier, string comments)
            : this(classIdentifier)
        {
            this.Comments = comments;
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.Teachers.Remove(teacher);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Class: " + ClassIdentifier);
            result.AppendLine();

            foreach (var teacher in Teachers)
            {
                result.Append(teacher.ToString());
            }

            foreach (var student in Students)
            {
                result.Append(student.ToString());
            }

            result.Append(Comments);
            result.AppendLine();
            return result.ToString();
        }
    }
}