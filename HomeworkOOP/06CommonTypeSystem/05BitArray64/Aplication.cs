using System;

class Aplication
{
    static void Main()
    {
        var numberOne = new BitArray64(ulong.MaxValue);
        var numberTwo = new BitArray64(ulong.MaxValue);

        foreach (var bit in numberOne)
        {
            Console.Write(bit);
        }
        Console.WriteLine();

        //Showing Equals
        Compare(numberOne.Equals(numberTwo));
        Compare(numberOne == numberTwo);

        Console.WriteLine(numberOne.GetHashCode());
    }

    private static void Compare(bool condtion)
    {
        if (condtion)
        {
            Console.WriteLine("Numbers are equal!");
        }
        else
        {
            Console.WriteLine("Numbers are not equal");
        }
    }
}