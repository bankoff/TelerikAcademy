/* Write a program that applies bonus scores to given scores in the range [1..9]. 
 * The program reads a digit as an input. If the digit is between 1 and 3, the 
 * program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
 * if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value 
 * is not a digit, the program must report an error.
 * Use a switch statement and at the end print the calculated new value in the console.
 */

using System;

    class BonusToGivenScores
    {
        static void Main()
        {
            Console.WriteLine("Input scores in range [1..9]:");
            string scoresStr = Console.ReadLine();
            int scores;
            switch (scoresStr)
            {
                case "1":
                    scores = int.Parse(scoresStr);
                    scores = scores * 10;
                    Console.WriteLine("New scores is:{0}",scores);
                    break;
                case "2":
                    scores = int.Parse(scoresStr);
                    scores = scores * 10;
                    Console.WriteLine("New scores is:{0}", scores);
                    break;
                case "3":
                    scores = int.Parse(scoresStr);
                    scores = scores * 10;
                    Console.WriteLine("New scores is:{0}", scores);
                    break;
                case "4":
                    scores = int.Parse(scoresStr);
                    scores = scores * 100;
                    Console.WriteLine("New scores is:{0}", scores);
                    break;
                case "5":
                    scores = int.Parse(scoresStr);
                    scores = scores * 100;
                    Console.WriteLine("New scores is:{0}", scores);
                    break;
                case "6":
                    scores = int.Parse(scoresStr);
                    scores = scores * 100;
                    Console.WriteLine("New scores is:{0}", scores);
                    break;
                case "7":
                    scores = int.Parse(scoresStr);
                    scores = scores * 1000;
                    Console.WriteLine("New scores is:{0}", scores);
                    break;
                case "8":
                    scores = int.Parse(scoresStr);
                    scores = scores * 1000;
                    Console.WriteLine("New scores is:{0}", scores);
                    break;
                case "9":
                    scores = int.Parse(scoresStr);
                    scores = scores * 1000;
                    Console.WriteLine("New scores is:{0}", scores);
                    break;
                default:
                    Console.WriteLine("This is not a digit in range [1..9]");
                    break;
            }
        }
    }

