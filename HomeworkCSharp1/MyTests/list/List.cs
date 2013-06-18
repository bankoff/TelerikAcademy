using System;
using System.Collections.Generic;
using System.Linq;


namespace list
{
    struct Rock
    {
        public Rock(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }
        public int X;
        public int Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new System.IO.StreamReader("input.txt"));// -> reads file from bin/debug directoy

            string line1 = Console.ReadLine();

            string line2 = Console.ReadLine();

            Console.WriteLine(line1);
            Console.WriteLine(line2);
            List<Rock> numbers = new List<Rock>();
            numbers.Add(new Rock(5, 6));
            numbers.Add(new Rock() { X = 5, Y = 45 });
            numbers.Add(new Rock() { X = 13, Y = 41 });
            numbers.Add(new Rock() { X = 25, Y = 4 });
            numbers.Add(new Rock() { X = 65, Y = 14 });
            numbers.Add(new Rock() { X = 53, Y = 12 });
            numbers = numbers.OrderBy(x => x.X).ToList();
            foreach (var item in numbers)
            {
                Console.WriteLine(item.X +" "+item.Y);
            }
          
        }
    }
}
