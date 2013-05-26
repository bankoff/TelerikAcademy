/* Write a program that, depending on the user's choice inputs int, 
 * double or string variable. If the variable is integer or double, 
 * increases it with 1. If the variable is string, appends "*" at its 
 * end. The program must show the value of that variable as a console 
 * output. Use switch statement.
 */ 

using System;

class VariablesIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Input type of data you will enter: 1 for int, 2 for double or 3 for string");
        byte typeOfVariable = byte.Parse(Console.ReadLine());
        Console.WriteLine("Input the variable:");
        string enteredVariable = Console.ReadLine();
        
        switch (typeOfVariable)
        {
            case 1:
                int enteredInteger = int.Parse(enteredVariable);
                Console.WriteLine("The new value is:{0}", (enteredInteger + 1));
                break;
            case 2:
                double enteredDouble = double.Parse(enteredVariable);
                Console.WriteLine("The new value is: {0}", (enteredDouble + 1));
                break;
            case 3:
                Console.WriteLine("The new value is: {0}*", enteredVariable);
                break;
            default: Console.WriteLine("Wrong input! You don't write 1 for int, 2 for double or 3 for string"); break;
        }
    }
}