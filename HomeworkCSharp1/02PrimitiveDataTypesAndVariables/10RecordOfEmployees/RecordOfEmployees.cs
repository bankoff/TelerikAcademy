/* A marketing firm wants to keep record of its employees. 
 * Each record would have the following characteristics – first name, 
 * family name, age, gender (m or f), ID number, unique employee number 
 * (27560000 to 27569999). Declare the variables needed to keep the information for 
 * a single employee using appropriate data types and descriptive names.
 */ 

using System;

class RecordOfEmployees
{
    static void Main()
    {
        string firstName = "Ivan";
        string familyName = "Ivanov";
        byte age = 42;
        char gender = 'm';
        ushort idNumber = 545;
        uint employeeNumber = 27560001;
        Console.WriteLine("Name: {0} {1}, age: {2}, gender: {3}, ID Number: {4},\n unique employee number {5}",
            firstName, familyName, age, gender, idNumber, employeeNumber);
    }
}
