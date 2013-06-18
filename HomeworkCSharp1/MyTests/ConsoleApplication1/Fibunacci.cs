using System;

class Fibunacci 
{ 
    static void Main() 
    { 
        decimal firstN = 1; 
        decimal secondN = 0; 
        decimal thirtN = 0; 
        for (int i = 0; i < 100; i++) 
        {
            Console.WriteLine(i +1 + ": " + thirtN);
            thirtN = firstN + secondN;
            firstN = secondN; secondN = thirtN;
             
        } 
    } 
}
