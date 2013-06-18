using System;

class AstrologicalDigits
{
    static void Main()
    {
        string number = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (!((number[i] == '-') || (number[i] == '.')))
            {
                sum = sum + int.Parse(number[i].ToString());
            } 
        }
        if (sum==0)
        {
            Console.WriteLine(0); 
        }
        else if (sum%9==0)
        {
            Console.WriteLine(9); 
        }
        else
        {
            Console.WriteLine(sum%9);
        }       
    }
}