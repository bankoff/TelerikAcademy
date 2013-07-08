using System;

namespace Variations
{
    class Program
    {
        static void Main()
        {
            //reading the input data from the console
            uint numberN;
            do
            {
                Console.Write("Please enter the number N: ");
            }
            while (!uint.TryParse(Console.ReadLine(), out numberN));
            uint numberK;
            do
            {
                Console.Write("Please enter the elements K: ");
            }
            while (!uint.TryParse(Console.ReadLine(), out numberK));

            //int numberN = int.Parse(Console.ReadLine());
            //int numberK = int.Parse(Console.ReadLine());

            // calculating the number of variations http://www.kombinatoruka.hit.bg/__7.html
            for (uint i = 0; i < Math.Pow(numberN, numberK); i++)
            {
                uint conv = i;
                uint[] num = new uint[numberK];

                //convert from decimal to n-number system
                for (uint j = 0; j < numberK; j++)
                {
                    num[numberK - j - 1] = conv % numberN;
                    conv = conv / numberN;
                }

                // print result
                Console.Write("{0}{1}", '{', num[0] + 1);
                for (uint j = 1; j < numberK; j++)
                {
                    Console.Write(", {0}", num[j] + 1);
                }
                Console.WriteLine("}");
            }
        }
    }
}