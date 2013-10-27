//5.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
//by first name and last name in descending order. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05SortStudents
{
    class TestOrderStudents
    {
        static void Main()
        {
            Student[] students = new Student[] { new Student(firstName: "Pesho", lastName:"Ivanov"), 
                                                new Student("Assen", "Georgiev"), 
                                                new Student("Ivanka",  "Tsoneva"),
                                                new Student( "Gogo", "Asenov"),
                                                new Student("Niki","Kostov"),
                                                new Student( "Ivanka",  "Asenova")};

            //Using Lambda Expressions
            OrderWithLambda(students);

            //Using LINQ 
            OrderWithLINQ(students);
        }

        private static void OrderWithLINQ(Student[] students)
        {
            var studentsSort = from student in students
                           orderby student.FirstName descending, student.LastName descending
                           select student;

            foreach (var student in studentsSort)
            {
                Console.WriteLine(student.ToString());
            }
        }

        private static void OrderWithLambda(Student[] students)
        {
            students = students.OrderByDescending(t => t.FirstName).ThenByDescending(t => t.LastName).ToArray();
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}