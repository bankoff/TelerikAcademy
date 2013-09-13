using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class KukataIsDancing
{
    static int[] CommandWalk(int[] position)
    {
        position[0]++;
        if (position[0]==3)
        {
            position[0] = 0; 
        }
        return position;
    }
    
    static int[] CommandRight(int[] position)
    {
        switch (position[0])
        {
            case 0:
                {
                    switch (position[1])
                    {
                        case 0: position[1] = 2; break;
                        case 1: position[0] = 1; position[1] = 2; break;
                        case 2: position[0] = 2; break;
                    }
                    break;
                }
            case 1:
                {
                    switch (position[1])
                    {
                        case 0: position[0] = 0; position[1] = 1; break;
                        case 1: break;
                        case 2: position[0] = 2; position[1] = 1; break;
                    }
                    break;
                }
            case 2:
                {
                    switch (position[1])
                    {
                        case 0: position[0] = 0; break;
                        case 1: position[0] = 1; position[1] = 0; break;
                        case 2: position[1] = 0; break;
                    }
                    break;
                }
        }
        return position;
    }
    
    static int[] CommandLeft(int[] position)
    {
        switch (position[0])
        {
            case 0:
                {
                    switch (position[1])
                    {
                        case 0: position[0] = 2; break;
                        case 1: position[0] = 1; position[1] = 0; break;
                        case 2: position[1] = 0; break;
                    }
                    break;
                }
            case 1:
                {
                    switch (position[1])
                    {
                        case 0: position[0] = 2; position[1] = 1; break;
                        case 1: break;
                        case 2: position[0] = 0; position[1] = 1; break;
                    }
                    break;
                }
            case 2:
                {
                    switch (position[1])
                    {
                        case 0: position[0] = 2; position[1] = 2; break;
                        case 1: position[0] = 1; position[1] = 2; break;
                        case 2: position[0] = 0; position[1] = 2; break;
                    }
                    break;
                }
        }
        return position;
    }

    static void PrintResult(string command)
    {
        string[,] matrix = new string[3, 3] { { "RED", "BLUE", "RED" }, { "BLUE", "GREEN", "BLUE" }, { "RED", "BLUE", "RED" } };
        int[] position = new int[] { 1, 1 };

        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == 'L')
            {
                position = CommandLeft(position);
            }
            else if (command[i] == 'R')
            {
                position = CommandRight(position);
            }
            else if (command[i] == 'W')
            {
                position = CommandWalk(position);
            }
        }

        Console.WriteLine(matrix[position[0], position[1]]);

    }

    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int[] position = new int[] { 1, 1 };

        for (int i = 0; i < rows; i++)
        {
            string command = Console.ReadLine();
            PrintResult(command);
        }
    }
}