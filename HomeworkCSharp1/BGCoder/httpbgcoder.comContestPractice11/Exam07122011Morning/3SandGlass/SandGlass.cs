using System;

class SandGlass
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());


        for (int row = 1; row <= number/2; row++)
        {


            for (int i = 1; i <= number; i++)
            {


                if ((i >= row) && (i <= number - row + 1))
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }


            }
            Console.WriteLine();
        }
        for (int row = number / 2+1; row >= 1 ; row--)
        {


            for (int i = 1; i <= number; i++)
            {


                if ((i >= row) && (i <= number - row + 1))
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }


            }
            Console.WriteLine();
        }
    }
}