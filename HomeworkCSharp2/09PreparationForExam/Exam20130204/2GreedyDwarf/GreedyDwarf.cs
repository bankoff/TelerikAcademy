using System;

class GreedyDwarf
{
    static long CalkCoinsNumber(int[] valley,int[] patern)
    {
        long coinsNumber = valley[0];
        bool[] flag = new bool[valley.Length];
        flag[0] = true;
        int i =0;

        while (true)
        {
            for (int j = 0; j < patern.Length; j++)
            {
                i = i + patern[j];
                if (i<0||i>=valley.Length||flag[i])
                {
                    return coinsNumber;
                }
                coinsNumber = coinsNumber + valley[i];
                flag[i] = true;
            }
        }
    }

    static int[] FillArray(string input)
    {
        char[] separator = new char[] {',',' '};
        string[] strArray = input.Split(separator,StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[strArray.Length];
        for (int i = 0; i < strArray.Length; i++)
        {
            arr[i] = int.Parse(strArray[i]);
        }
        return arr;
    }
    static void Main()
    {
        checked
        {
            int[] valley = FillArray(Console.ReadLine());
            int paternCount = int.Parse(Console.ReadLine());
            long result = long.MinValue;

            for (int i = 0; i < paternCount; i++)
            {
                int[] patern = FillArray(Console.ReadLine());
                long coinsNumber = CalkCoinsNumber(valley, patern);
                result = Math.Max(result, coinsNumber);
            }
            Console.WriteLine(result);
        }
    }
}