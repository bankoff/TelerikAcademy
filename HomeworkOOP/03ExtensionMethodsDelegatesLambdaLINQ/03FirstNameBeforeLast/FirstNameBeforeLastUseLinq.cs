//3.Write a method that from a given array of students finds all students whose first 
//name is before its last name alphabetically. Use LINQ query operators.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03FirstNameBeforeLast
{
    class FirstNameBeforeLastUseLinq
    {
        static void Main()
        {
            Student[] students = new Student[] { new Student( firstName : "Lili", lastName : "Ivanova" ), 
                                                new Student ("Iva", "Georgieva" ), 
                                                new Student ("Milka",  "Nikolova" ),
                                                new Student ( "Stefan", "Vazov" ),
                                                new Student ( "Mira",  "Stereva" )};

            PrintStudentsWithFirstNameBeforeLast(students);
        }

        private static void PrintStudentsWithFirstNameBeforeLast(Student[] students)
        {
            var studentsFirstBeforeLastName =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

            Console.WriteLine("The students whose first name is before its last name alphabetically are:");
            Console.WriteLine(new string('-', 20));
            foreach (var student in studentsFirstBeforeLastName)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}