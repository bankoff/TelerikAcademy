using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NineGagNumbers
{
    static int[] ReadInput()
    {
        string text = Console.ReadLine();
        List<int> number = new List<int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '-' && text[i + 1] == '!')
            {
                number.Add(0);
                i++;
            }

            else if (text[i] == '*')
            {
                if (text[i + 1] == '*')
                {
                    number.Add(1);
                    i++;
                }
                else if (text[i + 1] == '!' && text[i + 2] == '!' && text[i + 3] == '!')
                {
                    number.Add(6);
                    i = i + 3;
                }
            }

            else if (text[i] == '!')
            {
                if (text[i + 1] == '-')
                {
                    number.Add(5);
                    i++;
                }
                else if (text[i + 1] == '!')
                {
                    if (text[i + 2] == '!')
                    {
                        number.Add(2);
                        i = i + 2;
                    }
                    else if (text[i + 2] == '*' && text[i + 3] == '*' && text[i + 4] == '!' && text[i + 5] == '-')
                    {
                        number.Add(8);
                        i = i + 5;
                    }
                }
            }

            else if (text[i] == '&')
            {
                if (text[i + 1] == '&')
                {
                    number.Add(3);
                    i++;
                }
                else if (text[i + 1] == '-')
                {
                    number.Add(4);
                    i++;
                }
                else if (text[i + 1] == '*' && text[i + 2] == '!')
                {
                    number.Add(7);
                    i = i + 2;
                }
            }
        }

        return number.ToArray();
    }


    static void Main()
    {
        int[] input = ReadInput();
        ulong number = 0;
        ulong step = 1;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            number = number + (ulong)input[i] * step;
            step = step * 9;
        }
        Console.WriteLine(number);
    }
}