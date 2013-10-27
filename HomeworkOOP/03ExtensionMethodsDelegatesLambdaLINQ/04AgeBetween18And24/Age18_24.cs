//4.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04AgeBetween18And24
{
    class Age18_24
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[] { new Student( firstName:"Pepi", lastName:"Ivanov", age:19 ), 
                                    new Student("Miro","Georgiev", 25), 
                                    new Student("Ivanka", "Tsoneva",36 ),
                                    new Student("Iliana","Mileva", 22 ),
                                    new Student( "Ivo", "Kirov", 21 )};

            PrintStudentsBetween(students);
        }

        private static void PrintStudentsBetween(Student[] students)
        {
            var students18_24 =
            from student in students
            where student.Age <= 24 && student.Age >= 18
            select student;

            Console.WriteLine("The students whose age is between 18 and 24 are:");
            Console.WriteLine(new string('-', 20));
            foreach (var studentYoung in students18_24)
            {
                Console.WriteLine("{0,5} {1,5} {2,3}", studentYoung.FirstName, studentYoung.LastName, studentYoung.Age);
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}