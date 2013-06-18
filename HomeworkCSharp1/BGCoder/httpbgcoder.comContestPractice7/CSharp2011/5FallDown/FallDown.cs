using System;

class FallDown
{
    static void Main()
    {
        int n = 8;
        int[] bit = new int[n];
        int[] number = new int[n];
        int[] result = new int[n];
        int asist;
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
            }
        }

        for (int m = n-1; m >= 0; m--)
        {
            for (int position = 0; position < n; position++)
            {
                if (bit[position]>0)
                {
                    result[m] = result[m] + (int)Math.Pow(2, position);
                    bit[position]--;
                }
                
            } 
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
