using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_07GenericList
{
    class TestGenericList
    {
        static void Main(string[] args)
        {
            GenericList<int> listInt = new GenericList<int>();

            //Adding elements
            listInt.Add(99);
            listInt.Add(8);
            listInt.Add(0);
            listInt.Add(-7);
            listInt.Add(-9);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Test Adding elements");
            Console.WriteLine("{0}", listInt);
            Console.WriteLine();

            //Inserting Elements
            listInt.AddElementAtIndex(2, -22);
            listInt.AddElementAtIndex(0, -21);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Test Inserting elements");
            Console.WriteLine("{0}", listInt);
            Console.WriteLine();

            //Removing elements
            listInt.RemoveElementAtIndex(0);
            listInt.RemoveElementAtIndex(2);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Test Removing elements");
            Console.WriteLine("{0}", listInt);
            Console.WriteLine();

            //Index of element by its value 
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Test Index of elements");
            Console.WriteLine( "{0}", listInt.IndexOf(8));
            Console.WriteLine();

            //Min item
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Test finding min item");
            Console.WriteLine("{0}", listInt.Min<int>());
            Console.WriteLine();

            //Max item
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Test finding max item");
            Console.WriteLine("{0}", listInt.Max<int>());
            Console.WriteLine();
        }
    }
}
