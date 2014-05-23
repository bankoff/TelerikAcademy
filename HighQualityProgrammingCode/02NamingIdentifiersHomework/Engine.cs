namespace MineSweeper
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        public static void Main(string[] args)
        {
            const int MAX_OPEN_CELLS = 35;

            List<Score> champions = new List<Score>(6);

            string command = string.Empty;
            char[,] playField = CreatePlayfield();
            char[,] bombsField = PutBombs();

            int openCellsCount = 0;
            int row = 0;
            int col = 0;

            bool hitBomb = false;
            bool isNewGame = true;
            bool hasWon = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play mines”. Test your luck to find all fields without mines." + Environment.NewLine +
                        " Command 'top' shows the rating, 'restart' starts new game," + Environment.NewLine + "'exit' means Goodbye!");
                    CreateField(playField);
                    isNewGame = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= playField.GetLength(0) && col <= playField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GetRating(champions);
                        break;
                    case "restart":
                        playField = CreatePlayfield();
                        bombsField = PutBombs();
                        CreateField(playField);
                        hitBomb = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Good-bye!");
                        break;
                    case "turn":
                        if (bombsField[row, col] != '*')
                        {
                            if (bombsField[row, col] == '-')
                            {
                                RevealCell(playField, bombsField, row, col);
                                openCellsCount++;
                            }

                            if (MAX_OPEN_CELLS == openCellsCount)
                            {
                                hasWon = true;
                            }
                            else
                            {
                                CreateField(playField);
                            }
                        }
                        else
                        {
                            hitBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine(Environment.NewLine + "Error! Invalid command" + Environment.NewLine);
                        break;
                }

                if (hitBomb)
                {
                    CreateField(bombsField);
                    Console.Write(Environment.NewLine + "You are dead. Your points are {0}. " + "Write your name: ", openCellsCount);
                    string playerName = Console.ReadLine();
                    Score currentPlayerScore = new Score(playerName, openCellsCount);
                    if (champions.Count < 5)
                    {
                        champions.Add(currentPlayerScore);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < currentPlayerScore.Points)
                            {
                                champions.Insert(i, currentPlayerScore);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    champions.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    GetRating(champions);

                    playField = CreatePlayfield();
                    bombsField = PutBombs();
                    openCellsCount = 0;
                    hitBomb = false;
                    isNewGame = true;
                }

                if (hasWon)
                {
                    Console.WriteLine(Environment.NewLine + "Well done! No blood was shown in all 35 moves");
                    CreateField(bombsField);
                    Console.WriteLine("Write your name, please: ");
                    string successfulPlayerName = Console.ReadLine();
                    Score currentPlayerScore = new Score(successfulPlayerName, openCellsCount);
                    champions.Add(currentPlayerScore);
                    GetRating(champions);
                    playField = CreatePlayfield();
                    bombsField = PutBombs();
                    openCellsCount = 0;
                    hasWon = false;
                    isNewGame = true;
                }
            } 
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("Good-bye!");
            Console.Read();
        }

        private static void GetRating(List<Score> scoreInPoints)
        {
            Console.WriteLine(Environment.NewLine + "Points:");
            if (scoreInPoints.Count > 0)
            {
                for (int i = 0; i < scoreInPoints.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, scoreInPoints[i].Name, scoreInPoints[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rating!" + Environment.NewLine);
            }
        }

        private static void RevealCell(char[,] field, char[,] bombs, int row, int column)
        {
            char bombsCount = CalculateBombsInCells(bombs, row, column);
            bombs[row, column] = bombsCount;
            field[row, column] = bombsCount;
        }

        private static void CreateField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine(Environment.NewLine + "    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------" + Environment.NewLine);
        }

        private static char[,] CreatePlayfield()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] field = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> bombMap = new List<int>();
            while (bombMap.Count < 15)
            {
                Random random = new Random();
                int location = random.Next(50);
                if (!bombMap.Contains(location))
                {
                    bombMap.Add(location);
                }
            }

            foreach (int bombLocation in bombMap)
            {
                int column = bombLocation / cols;
                int row = bombLocation % cols;
                if (row == 0 && bombLocation != 0)
                {
                    column--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                field[column, row - 1] = '*';
            }

            return field;
        }

        private static char CalculateBombsInCells(char[,] field, int fieldRows, int fieldCols)
        {
            int bombCount = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (fieldRows - 1 >= 0)
            {
                if (field[fieldRows - 1, fieldCols] == '*')
                {
                    bombCount++;
                }
            }

            if (fieldRows + 1 < rows)
            {
                if (field[fieldRows + 1, fieldCols] == '*')
                {
                    bombCount++;
                }
            }

            if (fieldCols - 1 >= 0)
            {
                if (field[fieldRows, fieldCols - 1] == '*')
                {
                    bombCount++;
                }
            }

            if (fieldCols + 1 < cols)
            {
                if (field[fieldRows, fieldCols + 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((fieldRows - 1 >= 0) && (fieldCols - 1 >= 0))
            {
                if (field[fieldRows - 1, fieldCols - 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((fieldRows - 1 >= 0) && (fieldCols + 1 < cols))
            {
                if (field[fieldRows - 1, fieldCols + 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((fieldRows + 1 < rows) && (fieldCols - 1 >= 0))
            {
                if (field[fieldRows + 1, fieldCols - 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((fieldRows + 1 < rows) && (fieldCols + 1 < cols))
            {
                if (field[fieldRows + 1, fieldCols + 1] == '*')
                {
                    bombCount++;
                }
            }

            return char.Parse(bombCount.ToString());
        }
    }
}