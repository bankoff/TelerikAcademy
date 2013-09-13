using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CCharpBrackets
{
    static string[] Command()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
        List<string> result = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            string[] commands = word.Split(new char[] { '{', '}' },StringSplitOptions.RemoveEmptyEntries);
            int commandNumber = 0;

            for (int j = 0; j < word.Length; j++)
            {
                if (word[j] == '{')
                {
                    result.Add("{");
                }
                else if (word[j] == '}')
                {
                    result.Add("}");
                }
                else
                {
                    result.Add(commands[commandNumber]); 
                    j = j + commands[commandNumber].Length-1;
                    commandNumber++;
                }
            }
        }
        return result.ToArray();
    }


    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        string tab = Console.ReadLine();
        string[] input = new string[rows];
        StringBuilder result = new StringBuilder();

        int tabCount = 0;
        bool appTab=true;

        for (int i = 0; i < rows; i++)
        {
            string[] commands = Command();


            for (int j = 0; j < commands.Length; j++)
            {

                if (commands[j] == "{")
                {
                    if (j > 0 && !(commands[j - 1] == "{" || commands[j - 1] == "}"))
                    {
                        result.AppendLine();
                    }
                    //result.AppendLine();
                    for (int k = 0; k < tabCount; k++)
                    {
                        result.Append(tab);
                    }
                    tabCount++;
                    result.Append("{");
                    result.AppendLine();
                    appTab = true;
                }
                else if (commands[j] == "}")
                {
                    tabCount--;
                    if (j > 0 && !(commands[j - 1] == "{" || commands[j - 1] == "}"))
                    {
                        result.AppendLine();
                    }
                    for (int k = 0; k < tabCount; k++)
                    {
                        result.Append(tab);
                    }
                    result.Append("}");
                    result.AppendLine();
                    appTab = true;
                }
                else if (j < commands.Length - 1)
                {
                    if (appTab)
                    {
                        for (int k = 0; k < tabCount; k++)
                        {
                            result.Append(tab);
                        }
                    }
                    result.Append(commands[j] + " ");
                    appTab = false;
                }
                else
                {
                    if (appTab)
                    {
                        for (int k = 0; k < tabCount; k++)
                        {
                            result.Append(tab);
                        }
                    }
                    result.Append(commands[j]);
                    result.AppendLine();
                    appTab = true;
                }
            }
        }
        Console.WriteLine(result);
    }
}