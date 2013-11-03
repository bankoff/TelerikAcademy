//04. Create a class Person with two fields – name and age. Age can be left unspecified 
//    (may contain null value. Override ToString() to display the information of a person 
//    and if age is not specified – to say so. Write a program to test this functionality.

using System;

class Person
{
    public string Name { get; set; }
    public int? Age { get; set; }

    public Person(string name, int? age = null)
    {
        if (name == string.Empty || name == null || name.Length < 2)
        {
            throw new ArgumentOutOfRangeException("Invalid name. It should be at least three characters long.");
        }
        else
        {
            this.Name = name;
        }
        if (age != null)
        {
            if (age <= 0 || age >= 120)
            {
                throw new ArgumentOutOfRangeException("Invalid age. It should be in the range between 0 and 120.");
            }
            else
            {
                this.Age = age;
            }
        }
    }

    public override string ToString()
    {
        return String.Format("Name: {0}, Age: {1}", this.Name, (this.Age == null ? "<is not specified>" : this.Age.ToString()));
    }
}