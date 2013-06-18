using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if (x>0)
        {
            if (y>0)
            {
                Console.WriteLine(1);  
            }
            else if (y==0)
            {
                Console.WriteLine(6);
            }
            else
            {
                Console.WriteLine(4);
            }
        }
        else if (x==0)
        {
            if (y==0)
            {
                Console.WriteLine(0);  
            }
            else
            {
                Console.WriteLine(5);
            }
        }
        else
        {
            if (y > 0)
            {
                Console.WriteLine(2);
            }
            else if (y == 0)
            {
                Console.WriteLine(6);
            }
            else
            {
                Console.WriteLine(3);
            }     
        }

    }
}

