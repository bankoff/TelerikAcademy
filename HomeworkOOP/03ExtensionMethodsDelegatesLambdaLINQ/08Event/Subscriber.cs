using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08Event
{
    class Subscriber
    {
        public void Subscribe(Timer time)
        {
            time.RaiseCustomEvent += new Timer.ExecuteRepeatedlyPrintDelegate(PrintNote);
        }
        public static void PrintNote(Timer time, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('\u266B' + " ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
