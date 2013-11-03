using System;

class TestPerson
{
    static void Main()
    {
        var personOne = new Person("Gosho", 10);
        var personTwo = new Person("Pesho");

        Console.WriteLine(personOne.ToString());
        Console.WriteLine(personTwo.ToString());

        //var personThree = new Person("A", 23);
        //Console.WriteLine(personThree.ToString());

        //var personFour = new Person("Alex", 333);
        //Console.WriteLine(personFour.ToString());
    }
}