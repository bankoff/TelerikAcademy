using System;
using System.Linq;


class ReadNSequenceReturnMinMax
{

    static void Main()
    {

        Console.Write("Please enter how many numbers you want to have in a sequence: ");

        int numbers = int.Parse(Console.ReadLine());

        int i = 0;

        int[] array = new int[numbers];



        for (i = 0; i < numbers; i++)
        {

            Console.Write("Please enter a number:");

            array[i] = Convert.ToInt32(Console.ReadLine());


        }

        Console.WriteLine("\n\n");

        int max = array.Max();

        int min = array.Min();

        Console.WriteLine("The maximum value you have entered is {0}, the minimum is {1}", max, min);


    }

}