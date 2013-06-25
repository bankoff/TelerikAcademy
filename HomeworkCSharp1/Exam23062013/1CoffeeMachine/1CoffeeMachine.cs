using System;
using System.Threading;
using System.Globalization;

class CoffeeMachine
{
    static void Main()
    {
        checked
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int n = 5;
            int[] matrix = new int[n];
            double sumInMachine = 0;

            for (int i = 0; i < n; i++)
            {
                matrix[i] = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 0:
                        {
                            sumInMachine += matrix[i] * 0.05;
                            break;
                        }
                    case 1:
                        {
                            sumInMachine += matrix[i] * 0.1;
                            break;
                        }
                    case 2:
                        {
                            sumInMachine += matrix[i] * 0.2;
                            break;
                        }
                    case 3:
                        {
                            sumInMachine += matrix[i] * 0.5;
                            break;
                        }
                    case 4:
                        {
                            sumInMachine += matrix[i];
                            break;
                        }
                }
            }

            double programerMoney = double.Parse(Console.ReadLine());
            double priceOfDrink = double.Parse(Console.ReadLine());

            if (programerMoney >= priceOfDrink)
            {
                if ((programerMoney - priceOfDrink) > sumInMachine)
                {
                    Console.WriteLine("No {0:0.00}", programerMoney - priceOfDrink - sumInMachine);
                }
                else
                {
                    Console.WriteLine("Yes {0:0.00}", sumInMachine - (programerMoney - priceOfDrink));
                }
            }
            else
            {
                Console.WriteLine("More {0:0.00}", priceOfDrink - programerMoney);
            }
        }
    }
}