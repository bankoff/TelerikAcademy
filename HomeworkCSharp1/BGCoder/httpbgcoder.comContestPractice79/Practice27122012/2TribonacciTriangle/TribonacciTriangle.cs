using System;

class TribonacciTriangle
{
    static void Main()
    {
        long t1 = long.Parse(Console.ReadLine());
        long t2 = long.Parse(Console.ReadLine());
        long t3 = long.Parse(Console.ReadLine());
        int line = int.Parse(Console.ReadLine());

        Console.WriteLine(t1);
        Console.WriteLine("{0} {1}",t2,t3);


        long tN;
        for (int i = 3; i <= line; i++)
        {
            for (int j = 0; j < i; j++)
            {
                tN = t1 + t2 + t3;
                Console.Write(tN + " ");
                t1 = t2;
                t2 = t3;
                t3 = tN;
            }
            Console.WriteLine();
        }
    }
}