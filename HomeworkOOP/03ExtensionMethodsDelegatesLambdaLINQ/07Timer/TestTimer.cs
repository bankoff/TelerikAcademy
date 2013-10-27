//7.Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Timer
{
    class TestTimer
    {
        public static void PrintNote()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('\u266B' + " ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main()
        {
            Timer.RepeatWithDelegate(PrintNote, 1, 5);
            Console.WriteLine();
            Console.WriteLine("Done. Have a nice day!");
        }
    }
}