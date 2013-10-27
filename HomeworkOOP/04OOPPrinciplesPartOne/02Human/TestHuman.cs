using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Human
{
    class TestHuman
    {
        static void Main(string[] args)
        {
            //Defining 10 Students and adding them to list: 
            List<Student> studentGroup = new List<Student>();

            studentGroup.Add(new Student("Bobi", "Savov", 5.50));
            studentGroup.Add(new Student("Mario", "Jovov", 2.50));
            studentGroup.Add(new Student("Todor", "Lalov", 5.30));
            studentGroup.Add(new Student("Bojidar", "Cvetkov", 3.50));
            studentGroup.Add(new Student("Vanja", "Valeva", 5.50));
            studentGroup.Add(new Student("Mira", "Vaseva", 4.80));
            studentGroup.Add(new Student("Joro", "Stamatov", 4.10));
            studentGroup.Add(new Student("Petar", "Ivanov", 3.90));
            studentGroup.Add(new Student("Alex", "Rumenov", 3.76));
            studentGroup.Add(new Student("Elena", "Yoncheva", 5.80));

            //Showing sorted Students List with labda expression: 
            studentGroup = studentGroup.OrderBy(t => t.Grade).ToList();
            foreach (var element in studentGroup)
            {
                Console.WriteLine(element.ToString());
            }

            //Defining 10 Workers and adding them to list: 
            List<Worker> workersGroup = new List<Worker>();

            workersGroup.Add(new Worker("Joro", "Cvetkov", 220.44m, 8));
            workersGroup.Add(new Worker("Vyara", "Jordanova", 260.64m, 8));
            workersGroup.Add(new Worker("Joana", "Mileva", 350.34m, 8));
            workersGroup.Add(new Worker("Maia", "Lilova", 230.65m, 8));
            workersGroup.Add(new Worker("Bilyana", "Simova", 140.12m, 8));
            workersGroup.Add(new Worker("Lili", "Stefanova", 254.83m, 8));
            workersGroup.Add(new Worker("Petar", "Vazov", 223.14m, 8));
            workersGroup.Add(new Worker("Todor", "Salpaov", 543.43m, 8));
            workersGroup.Add(new Worker("Alex", "Iliev", 234.18m, 8));
            workersGroup.Add(new Worker("Elena", "Rubeva", 643.16m, 8));

            //Showing sorted Workers List with lambda expression: 
            workersGroup = workersGroup.OrderByDescending(t => t.MoneyPerHour).ToList();
            Console.WriteLine();
            foreach (var worker in workersGroup)
            {
                Console.WriteLine(worker.ToString());
            }

            //Merging both Lists and showing result. Using lambda expression for sorting.
            var mergedlists = studentGroup.Concat<Human>(workersGroup).ToList();
            mergedlists = mergedlists.OrderBy(t => t.FirstName).ThenBy(t => t.LastName).ToList();
            Console.WriteLine();
            foreach (var human in mergedlists)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }
}