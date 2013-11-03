using System;
using System.Collections.Generic;

class TestProgram
{
    static void Main()
    {
        Student first = new Student("Ivan", "Iliev", "Ivanov", 9999, "Sofia, 22, Slivnitza Blvd", "0888888888", 
            "ivan@mail.bg", 2, Specialties.Engineering, Universities.TechnicalUniversity, Faculties.MechanicallEngineering);

        Console.WriteLine("Original:" + first);

        Student cloned = first.Clone();

        Console.WriteLine("Cloned:{0}", cloned);

        Console.WriteLine("First and Cloned are the same students: {0}", first.Equals(cloned));

        Console.WriteLine();

        cloned.SSN = 2323;
        Console.WriteLine("Cloned :{0} with changed SSN", cloned);
        Console.WriteLine("Original of the cloned {0}", first);

        Console.WriteLine("First and Cloned are the same students after the change of SSN of cloned: {0}", first.Equals(cloned));
        Console.WriteLine();

        Console.WriteLine("Other students:");
        Student second = new Student("Iliana", "Ivanova", "Savova", 12111, "Sofia, 64, Bulgaria Blvd", "0888888128", 
            "iliana@abv.bg", 2,Specialties.Chemistry,Universities.SofiaUniversity,Faculties.Chemistry);
        Console.WriteLine(second);
        Student third = new Student("Penka", "Mincheva", "Manolova", 23400, "Sofia, 84, Vasil Levski Blvd", "0888988123", 
            "penka@abv.bg",3,Specialties.Biotechnology,Universities.SofiaUniversity,Faculties.Biology);
        Console.WriteLine(third);
        Student fourth = new Student("Anton", "Georgiev", "Milev", 4646, "Sofia, 49, Hristo Botev Blvd", "0888887123", 
            "anton@abv.bg",1,Specialties.ComputerSystems,Universities.TechnicalUniversity,Faculties.IT);
        Console.WriteLine(fourth);

        List<Student> sortedStudents = new List<Student>();
        sortedStudents.Add(first);
        sortedStudents.Add(second);
        sortedStudents.Add(cloned);
        sortedStudents.Add(third);
        sortedStudents.Add(fourth);

        sortedStudents.Sort();

        Console.WriteLine();
        Console.WriteLine("The sorted students are:");

        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
    }
}