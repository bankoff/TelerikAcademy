using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mobile.Phones;
using System.Threading;
using System.Globalization;

namespace GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            GSM NokiaGSM = new GSM("N-30", "Nokia", 180m, new Person("Gogo"), new Battery("825L", 123, 100, BatteryType.LiIon), new Display(15, 1024));

            NokiaGSM.AddCall(new Call(DateTime.Now, "088888888", 156));
            NokiaGSM.AddCall(new Call(DateTime.Now.AddDays(3), "0888888899", 12));
            NokiaGSM.AddCall(new Call(DateTime.Now.AddHours(1), "0888888344", 100));
            NokiaGSM.AddCall(new Call(DateTime.Now.AddHours(56), "088883443", 1500));

            decimal maxDuration = NokiaGSM.CallHistory[0].DurationInSeconds;
            int positionMaxDurationCall = 0;

            for (int i = 0; i < NokiaGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("{0} call {1}", i + 1, NokiaGSM.CallHistory[i]);
                Console.WriteLine();
                if (NokiaGSM.CallHistory[i].DurationInSeconds > maxDuration)
                {
                    maxDuration = NokiaGSM.CallHistory[i].DurationInSeconds;
                    positionMaxDurationCall = i;
                }
            }

            Console.WriteLine(new string('-', 50));
            Console.Write("The total price of your {0} calls is:  ", NokiaGSM.CallHistory.Count);

            Console.WriteLine(NokiaGSM.CalculatePrice(0.37m));

            NokiaGSM.RemoveCall(NokiaGSM.CallHistory[positionMaxDurationCall]);

            Console.Write("The total price of your {0} calls without the longest one is:  ", NokiaGSM.CallHistory.Count);
            Console.WriteLine(NokiaGSM.CalculatePrice(0.37m));

            NokiaGSM.ClearHistory(NokiaGSM.CallHistory);
            Console.Write("After clearing the history, there are {0} calls.", NokiaGSM.CallHistory.Count);

            Console.WriteLine();
        }
    }
}
