namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            if (a + b <= c || b + c <= a || c + a <= b)
            {
                throw new ArgumentOutOfRangeException("Sum of two sides should be bigger then third side.");
            }

            // Heron's formula
            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            return area;
        }

        public static string DigitToEnglishWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";

                default: throw new ArgumentOutOfRangeException("Unknown digit!");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Array does not contain elements!");
            }

            int max = int.MinValue;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double distance = Math.Sqrt(((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X)) +
                ((secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y)));

            return distance;
        }

        public static bool IsHorizontalLine(Point firstPoint, Point secondPoint)
        {
            bool isHorizontalLine = firstPoint.Y == secondPoint.Y;

            return isHorizontalLine;
        }

        public static bool IsVerticalLine(Point firstPoint, Point secondPoint)
        {
            bool isHorizontalLine = firstPoint.X == secondPoint.X;

            return isHorizontalLine;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(DigitToEnglishWord(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            Print.AsFloatNumber(1.3);
            Print.AsPercent(0.75);
            Print.RightAlignedNumber(2.30);

            Point firstPoint = new Point() { X = 3, Y = -1 };
            Point secondPoint = new Point() { X = 3, Y = 2.5 };

            Console.WriteLine(CalculateDistance(firstPoint, secondPoint));
            Console.WriteLine("Horizontal? " + IsHorizontalLine(firstPoint, secondPoint));
            Console.WriteLine("Vertical? " + IsVerticalLine(firstPoint, secondPoint));

            Student peter = new Student("Peter", "Ivanov", "From Sofia, born at 17.03.1992");

            Student stella = new Student("Stella", "Markova", "From Vidin, gamer, high results, born at 03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.BirthDate().IsEarlierThan(stella.BirthDate()));
        }
    }
}
