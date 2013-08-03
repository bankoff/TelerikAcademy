using System;
using System.Text;
using System.Threading;

class PrintOnConsole
{
    static void Main()
    {
         Console.OutputEncoding = Encoding.UTF8;
        char n;
        for (int i = 0; i < 256; i++)
        {
            n = (char)i;
       
            Console.Write(n);

        }
        Console.WriteLine();
        char h = (char)173;
        int k = 0;

        //while (true)
        //{

        //    for (int i = 0; i < k; i++)
        //    {
        //        Console.WriteLine(); 
        //    }
        //    Console.Write(h);
        //    h++;
        //    Console.Write(h);
        //    h++;
        //    Console.Write(h);
        //    Thread.Sleep(200);
        //    Console.Clear();
        //    k++;

        //    for (int i = 0; i < k; i++)
        //    {
        //        Console.WriteLine();
        //    }

        //    Console.Write(h);
        //    h--;
        //    Console.Write(h);
        //    h--;
        //    Console.Write(h);
        //    Thread.Sleep(200);
        //    Console.Clear();

        //    k++;

        //}
    }
}