using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using Mobile.Phones;

namespace GSMTest
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            GSM Alcatel = new GSM("OT-11","Alcatel",34.25m,new Person("Misho"),new Battery("j89",5.4,3.2,BatteryType.LiIon),new Display(3.6,256));
            GSM Nokia = new GSM("100", "Nokia", 250m, new Person("Gogo"), new Battery("82L", 12, 10, BatteryType.LiIon), new Display(20, 64));
            GSM HTC = new GSM("NK", "HTC", 130m, new Person("Nana"), new Battery("K9092", 26, 9, BatteryType.NiCd), new Display(10, 128));
            GSM Motorolla = new GSM("A-12", "Motorolla", 10m, new Person("Ivo"), new Battery("L92", 13, 3, BatteryType.NiMH), new Display(12, 1024));

            GSM[] gsms = new GSM[] { Nokia, HTC, Motorolla };
            foreach (GSM phone in gsms)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine();
            }
            Console.WriteLine(GSM.IPhone4S.ToString());

        }
    }
}
