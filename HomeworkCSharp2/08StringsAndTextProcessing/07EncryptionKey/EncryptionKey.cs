//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing 
//XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncryptionKey
{
    static void Main()
    {
        string text = @"We are living in an yellow submarine.
We don't have anything else. Inside the submarine is very tight.
So we are drinking all the day. We will move out of it in 5 days.";
        string key = "telerik";

        //Console.WriteLine("Please enter some text!");
        //string text = Console.ReadLine();
        //Console.WriteLine("Please enter encryption key!");
        //string key = Console.ReadLine();

        Console.WriteLine("The encoded text is:");
        Console.WriteLine(Encode(text, key));
        Console.WriteLine();
        Console.WriteLine("The decoded text is:");
        Console.WriteLine(Decode(Encode(text, key), key));
        Console.WriteLine();
    }

    static string Encode(string text, string key)
    {
        StringBuilder encoded = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            encoded.Append((char)(text[i] ^ key[i % key.Length]));
        }
        return encoded.ToString();
    }

    static string Decode(string text, string key)
    {
        return Encode(text, key);
    }
}