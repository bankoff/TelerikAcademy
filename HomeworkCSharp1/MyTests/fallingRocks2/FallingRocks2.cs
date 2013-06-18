using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Falling_Rocks
{
    class Program
    {
        static int shipXposition = Console.WindowWidth / 2; //Starting Ship Position
        static int shipYposition = Console.WindowHeight - 1;
        static string ship = "(0)"; //Ship Appereance
        static Random generator = new Random(); //Random generator
        static List<List<int>> rocksXposition = new List<List<int>>(); //Store information about the X-coordinate of each rock
        static int rocksYposition = 0; //Counter for Y-coordinate of rocks when they are less than console.windowheight
        static String[] colorNames = { "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White" }; //List of the rocks-colors
        static List<List<string>> rocksColors = new List<List<string>>(); //Store information about the color of each rock
        static string symbols = "!@#$%^&*"; //Symbols used as rocks in the game
        static List<List<char>> rocksSymbols = new List<List<char>>(); //Store information about the symbol of each rock
        static int minSymbolsPerRow = 1;
        static int maxSymbolsPerRow = 1;
        static int minXrockPosition = 1;
        static int maxXrockPosition = Console.WindowWidth - 1;
        static int points = 0;
        static int gameSpeed = 350;
        static int gameLevelHolder = 0;

        static void SetInitialValues()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        static void GenerateNewRocks()
        {
            rocksXposition.Add(new List<int>());
            rocksColors.Add(new List<string>());
            rocksSymbols.Add(new List<char>());

            int numberOfSymbols = generator.Next(minSymbolsPerRow, maxSymbolsPerRow);
            for (int i = 0; i < numberOfSymbols; i++)
            {
                rocksXposition[rocksXposition.Count - 1].Add(generator.Next(minXrockPosition, maxXrockPosition)); //Store each rock-X-coordinate
                string randomColor = colorNames[generator.Next(colorNames.Length)]; //Generate random rock-color name
                rocksColors[rocksColors.Count - 1].Add(randomColor); //Store each rock-color
                int randomSymbol = generator.Next(symbols.Length); // Generate random rock-symbol
                rocksSymbols[rocksSymbols.Count - 1].Add(symbols[randomSymbol]); //Store each rock symbol
            }
        }

        static void RemoveFirstRowOfRocks()
        {
            points += rocksXposition[0].Count;
            rocksXposition.RemoveAt(0);
            rocksColors.RemoveAt(0);
            rocksSymbols.RemoveAt(0);
            GenerateNewRocks();
        }

        static void PrintShip()
        {
            Console.ResetColor();
            Console.SetCursorPosition(shipXposition, shipYposition);
            Console.WriteLine(ship);
        }

        static void MoveShipRight()
        {
            if (shipXposition < Console.WindowWidth - 4)
            {
                shipXposition++;
            }
        }

        static void MoveShipLeft()
        {
            if (shipXposition > 1)
            {
                shipXposition--;
            }
        }

        static void PrintRocks()
        {
            if (rocksYposition < shipYposition)
            {
                GenerateNewRocks();
                for (int row = 0; row <= rocksYposition; row++)
                {
                    for (int col = 0; col < rocksXposition[row].Count; col++)
                    {
                        Console.SetCursorPosition(rocksXposition[row][col], rocksYposition - row);
                        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), rocksColors[row][col]); //Set Random Foreground color
                        Console.WriteLine("{0}", rocksSymbols[row][col]);
                    }
                }
            }
            else
            {
                RemoveFirstRowOfRocks();
                bool rockHitShip = false;
                for (int row = 0; row < Console.WindowHeight - 1; row++)//same code is used
                {
                    for (int col = 0; col < rocksXposition[row].Count; col++)
                    {
                        Console.SetCursorPosition(rocksXposition[row][col], Console.WindowHeight - 2 - row);
                        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), rocksColors[row][col]); //Set Random Foreground color
                        Console.WriteLine("{0}", rocksSymbols[row][col]);
                        if (row == 0 && (rocksXposition[0][col] == shipXposition || rocksXposition[0][col] == shipXposition + 1
                            || rocksXposition[0][col] == shipXposition + 2))
                        {
                            rockHitShip = true;
                        }
                    }
                }
                if (rockHitShip == true)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2);
                    Console.ResetColor();
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU HAVE CRASHED INTO A ROCK WITH {0} POINTS", points);
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 + 1);
                    Console.WriteLine("PRESS ENTER/SPACE TO START OVER");
                    points = 0;
                    gameLevelHolder = 0;
                    minSymbolsPerRow = 1;
                    maxSymbolsPerRow = 2;
                    gameSpeed = 350;
                    rockHitShip = false;
                    ConsoleKeyInfo pressEnterSpace;
                    do
                    {
                        Console.ResetColor();
                        Console.SetCursorPosition(0, 0);
                        pressEnterSpace = Console.ReadKey();

                    } while (pressEnterSpace.Key != ConsoleKey.Enter && pressEnterSpace.Key != ConsoleKey.Spacebar);
                    rocksYposition = -1;
                    rocksXposition.Clear();
                    rocksColors.Clear();
                    rocksSymbols.Clear();
                }
            }
        }

        static void MoveRocksDown()
        {
            rocksYposition++;
        }

        static void GameLevel()
        {
            gameLevelHolder = points / 100;
            if (minSymbolsPerRow < 5) minSymbolsPerRow = 1 + points / 500;
            if (maxSymbolsPerRow <= 10) maxSymbolsPerRow = 1 + points / 250;
            if (gameSpeed > 100) gameSpeed = 350 - points / 10;

        }

        static void PrintPoints()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth - 16 - (points.ToString()).Length, 0);
            Console.WriteLine("LEVEL-{0}/POINTS={1}", gameLevelHolder, points);
            Console.ResetColor();
        }

        static void Main()
        {
            SetInitialValues();

            while (true)
            {
                Console.Clear();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    
                    
                    
                    //ConsoleKeyInfo keyPressed = Console.ReadKey();
                    if (keyPressed.Key == ConsoleKey.RightArrow)
                    {
                        MoveShipRight();
                    }
                    else if (keyPressed.Key == ConsoleKey.LeftArrow)
                    {
                        MoveShipLeft();
                    }
                }
                PrintShip();
                PrintRocks();
                PrintPoints();
                MoveRocksDown();
                GameLevel();
                System.Threading.Thread.Sleep(gameSpeed);
            }
        }
    }
}