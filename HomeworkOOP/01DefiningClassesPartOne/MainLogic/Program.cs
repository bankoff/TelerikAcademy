using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mobile.Phones;

namespace MainLogic
{
    class Program
    {
        static void Main()
        {
            Person pesho = new Person("Pesho");

            Display display = new Display(5.4, 16000);

            Battery battery = new Battery("5KR76", 6.4, 4.1, BatteryType.NiCd);

            GSM gsm = new GSM("C30", "Nokia", 45.46m, pesho, battery, display);
            //GSM gsm = new GSM("C30", "Nokia", owner: pesho, display: display);

            Console.WriteLine(gsm.ToString());
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
