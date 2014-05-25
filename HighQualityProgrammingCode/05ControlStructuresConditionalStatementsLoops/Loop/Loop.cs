namespace Loop
{
    using System;

    public class Loop
    {
        public static void Main()
        {
            int arrayLength = 100;
            int[] array = new int[arrayLength];

            // fill array
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = i * 2;
            }

            int expectedValue = 40;
            int divider = 10;

            bool hasExpectedValue = false;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(array[i]);

                if (i % divider == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        hasExpectedValue = true;
                        break;
                    }
                }
            }

            // More code here
            if (hasExpectedValue)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
