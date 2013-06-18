using System;

class Pillars
{
    static void Main()
    {
        {
            int n = 8;
            int[] bit = new int[n];
            int[] number = new int[n];
            int[] result = new int[n];
            int asist;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                number[i] = byte.Parse(Console.ReadLine());
            }

            for (int k = 0; k < n; k++)
            {


                for (int position = 0; position < n; position++)
                {
                    asist = (number[k] >> position) & 1;
                    bit[position] = bit[position] + asist;
                    sum = sum + asist;
                }
            }
            if (sum == bit[7])
            {
                Console.WriteLine(7);
                Console.WriteLine(0);
            }
            else if (sum == bit[0])
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
            else
            {
                int sumLeft = bit[7];
                int sumRight = bit[0];
                int p = 0;
                int q = 7;

                while (!(p == q - 2))
                {

                    if (sumLeft > sumRight)
                    {
                        sumRight = sumRight + bit[p + 1];
                        p++;
                    }
                    else if ((sumLeft == sumRight) && (bit[p + 1] == 0))
                    {
                        p++;
                    }
                    else
                    {
                        sumLeft = sumLeft + bit[q - 1];
                        q--;
                    }
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(p + 1);
                    Console.WriteLine(sumLeft);
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
