namespace _2CreateHuman
{
    using System;

    public class CreatingPersonsTest
    {
        public static void Main(string[] args)
        {
            Person newPersonOne = Person.CreatePerson(20);
            Person newPersonTwo = Person.CreatePerson(23);

            Console.WriteLine("Name: {0}, Age: {1}, Gender {2}", newPersonOne.Name, newPersonOne.Age, newPersonOne.Sex);
            Console.WriteLine("Name: {0}, Age: {1}, Gender {2}", newPersonTwo.Name, newPersonTwo.Age, newPersonTwo.Sex);
        }
    }
}