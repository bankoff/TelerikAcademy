using System;
using System.Threading;
using System.Globalization;


class Neurons
{
    static void Main()
    {
        checked
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            long number = 0;
            long newNumber = 0;
            long[] bit = new long[32];

            while (true)
            {
                string flag = "no";

                number = long.Parse(Console.ReadLine());

                if (number == -1)
                {
                    break;
                }

                for (int i = 0; i < 32; i++)
                {
                    bit[i] = (number >> i) & 1;
                }

                for (int i = 0; i < 32; i++)
                {
                    if (bit[i] == 1 && flag == "no")
                    {
                        flag = "up";
                    }
                    if (bit[i] == 0 && flag == "up")
                    {
                        flag = "next";
                    }
                    if (bit[i] == 1 && flag == "next")
                    {
                        flag = "change";
                    }
                }

                if (flag == "change")
                {

                    while (true)
                    {
                        int counter = 0;
                        while (bit[counter] == 0)
                        {
                            counter++;
                        }

                        while (bit[counter] == 1)
                        {
                            bit[counter] = 0;
                            counter++;
                        }

                        while (bit[counter] == 0)
                        {
                            bit[counter] = 1;
                            counter++;
                        }

                        while (bit[counter] == 1)
                        {
                            bit[counter] = 0;
                            counter++;
                            if (counter == 32)
                            {
                                break;
                            }
                        }
                        break;
                    }

                    for (int i = 0; i < 32; i++)
                    {
                        newNumber = newNumber | bit[i] << i;
                    }

                    Console.WriteLine(newNumber);
                    newNumber = 0;
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}