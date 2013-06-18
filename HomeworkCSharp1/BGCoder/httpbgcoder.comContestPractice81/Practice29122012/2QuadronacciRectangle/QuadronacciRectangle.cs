using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long numberOne = long.Parse(Console.ReadLine());
        long numberTwo = long.Parse(Console.ReadLine());
        long numberThree = long.Parse(Console.ReadLine());
        long numberFour = long.Parse(Console.ReadLine());
        int numberRow = int.Parse(Console.ReadLine());
        int numberColumn = int.Parse(Console.ReadLine());

        long numberFive;
        for (int i = 0; i < numberRow; i++)
        {
            int start = 0;
            if (i == 0)
            {
                Console.Write("{0} {1} {2} {3} ", numberOne, numberTwo, numberThree, numberFour);
                start = 4;
            }
            for (int j = start; j < numberColumn; j++)
            {
                numberFive = numberOne + numberTwo + numberThree + numberFour;
                Console.Write("{0} ",numberFive);
                numberOne = numberTwo;
                numberTwo = numberThree;
                numberThree = numberFour;
                numberFour = numberFive;
            }
            Console.WriteLine();
        }
    }
}