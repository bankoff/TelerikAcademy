using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int[] number = new int[5];
        int divider;
        int result = 1;
        int endResult = 1000000;
        int a1,a2,a3,maxA;
        for (int i = 0; i < 5; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 3; i++)
        {
            for (int k = i+1; k < 4; k++)
            {
                for (int m = k+1; m < 5; m++)
                {
                    a1 = number[i];
                    a2 = number[k];
                    a3 = number[m];
                    maxA = Math.Max(a1,Math.Max(a2, a3));
                    divider = 2;
                    
                    while (divider<=maxA)
                    {
                        while (a1%divider == 0 || a2%divider == 0 || a3%divider == 0)
                        {
                            if (a1%divider == 0)
                            {
                                a1 = a1 / divider;
                            }
                            if (a2%divider == 0)
                            {
                                a2 = a2 / divider;
                            }
                            if (a3 % divider == 0)
                            {
                                a3 = a3 / divider;
                            }
                            result = result * divider;
                        }
                        divider++;
                    }
                    if (result<endResult)
                    {
                        endResult = result; 
                    }
                    result = 1;
                
                }
            }
        }
        Console.WriteLine(endResult);
    }
}
