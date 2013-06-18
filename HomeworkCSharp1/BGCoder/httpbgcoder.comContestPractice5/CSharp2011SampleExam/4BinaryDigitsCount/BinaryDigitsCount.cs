using System;

class BinaryDigitsCount
{
    static void Main()
    {

        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        uint[] number = new uint[n];
        for (int i = 0; i < n; i++)
        {
            number[i] = uint.Parse(Console.ReadLine());
        }

        int result;
        uint check;
        
        for (int i = 0; i < n; i++)
        {
            result = 0;
            bool counter = false;

            for (int k = 31; k >= 0; k--)
            {
                check = ((number[i] >> k) & 1);
                if (check == 1)
                {
                    counter = true; 
                }
                if (counter==true && check==b)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }

    }
}