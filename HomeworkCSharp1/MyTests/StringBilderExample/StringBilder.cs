using System;
using System.Text;

namespace StringBilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = new DateTime();

            start = DateTime.Now;
            string name = "Pesho";

            StringBuilder result = new StringBuilder();
            result.Append(name);
            for (int i = 0; i < 50000; i++)
            {
                //name += 'o';
                result.Append('o');
                //result.AppendLine("o");
            }

            //Console.WriteLine(name);
            Console.WriteLine(result.ToString());
            Console.WriteLine(DateTime.Now - start);
        }
    }
}
