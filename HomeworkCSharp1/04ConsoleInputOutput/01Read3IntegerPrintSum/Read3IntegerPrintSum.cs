// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

    class Read3IntegerPrintSum
    {
        static void Main()
        {
            Console.WriteLine("Input first integer and then press Enter");
            Console.Write("integer1 = ");
            string integer1Str = Console.ReadLine();
            int integer1 = int.Parse(integer1Str);

            Console.WriteLine("Input second integer and then press Enter");
            Console.Write("integer2 = ");
            string integer2Str = Console.ReadLine();
            int integer2 = int.Parse(integer2Str);

            Console.WriteLine("Input third integer and then press Enter");
            Console.Write("integer3 = ");
            string integer3Str = Console.ReadLine();
            int integer3 = int.Parse(integer3Str);

            int sum = integer1 + integer2 + integer3;
            Console.WriteLine("{0} + {1} + {2} = {3}",integer1,integer2,integer3,sum);
        }
    }

