using System;
using System.Threading;
using System.Globalization;

class DrunkenNumbers
{
    static void Main()
    {
        checked
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            long rounds = long.Parse(Console.ReadLine());
            string[] beers = new string[rounds];
            long beersMitko = 0;
            long beersVladko = 0;
            long beersShared = 0;

            for (int i = 0; i < rounds; i++)
            {
                beers[i] = Console.ReadLine();

                long tempNumber = long.Parse(beers[i]);

                if (tempNumber < 0)
                {
                    tempNumber = (-tempNumber);
                }

                string temp = tempNumber.ToString();
                int k = 0;

                for (int j = 0; j < (temp.Length / 2); j++)
                {
                    beersMitko = beersMitko + temp[j] - 48;
                }

                if (temp.Length % 2 == 1)
                {
                    beersShared = beersShared + temp[temp.Length / 2] - 48;
                    k = 1;
                }

                for (int j = (temp.Length / 2) + k; j < temp.Length; j++)
                {
                    beersVladko = beersVladko + temp[j] - 48;
                }
            }

            if (beersMitko > beersVladko)
            {
                Console.WriteLine("M {0}", beersMitko - beersVladko);
            }
            else if (beersVladko > beersMitko)
            {
                Console.WriteLine("V {0}", beersVladko - beersMitko);
            }
            else
            {
                Console.WriteLine("No {0}", beersMitko + beersVladko + 2 * beersShared);
            }
        }
    }
}