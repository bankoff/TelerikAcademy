namespace Methods
{
    using System;

    public static class Print
    {
        public static void AsFloatNumber(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void AsPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void RightAlignedNumber(object number)
        {
            Console.WriteLine("{0,8}", number);
        }
    }
}
