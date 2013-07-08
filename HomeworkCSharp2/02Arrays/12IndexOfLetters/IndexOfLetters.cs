// Write a program that creates an array containing all letters from the alphabet (A-Z). 
// Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];   //creates the array
        int startOfArray = 65;           //'A' has value of 65.
        
        //fills the array 
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)startOfArray;
            startOfArray++;
        }

        //input the word and convert to uppercase
        Console.Write("Please enter a word with capital letters: ");
        string enteredWord = Console.ReadLine().ToUpper();

        //print the index of each of the letters of the word, starting from zero
        foreach (char letter in enteredWord)
        {
            for (int i = 0; i < 26; i++)
            {
                if (alphabet[i] == letter)
                {
                    Console.WriteLine("The index of the letter {0} is {1}, starting counting from zero", letter, i);
                    break;
                }
            }
        }
    }
}