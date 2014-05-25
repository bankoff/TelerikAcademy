namespace RefactorIfStatements
{
    using System;

    public class Cell
    {
        public const int MinRow = 10;
        public const int MaxRow = 20;
        public const int MinColumn = 50;
        public const int MaxColumn = 100;

        public static void Main()
        {
            int row = 7;
            int column = 70;

            bool shouldVisitCell = true;
            bool rowInRange = MinRow <= row && row <= MaxRow;
            bool columnInRange = MinColumn <= column && column <= MaxColumn;

            if (shouldVisitCell && rowInRange && columnInRange)
            {
                VisitCell();
            }
        }

        public static void VisitCell()
        {
            Console.WriteLine("This cell has visited before");
        }
    }
}
