//1.Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of 
//the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable 
//constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() 
//method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes 
//(Circle, Rectangle, Triangle) stored in an array.

using System;

class TestProgram
{
    static void Main()
    {
        var rectangle = new Rectangle(4, 6);
        var area = rectangle.CalculateSurface();
        Console.WriteLine(area);
        var triangle = new Triangle(4, 3);
        var triangleArea = triangle.CalculateSurface();
        Console.WriteLine(triangleArea);
        //Throws an Exception
        //var circle = new Circle(2, 3);
        var circle = new Circle(3, 3);
        Console.WriteLine(circle.CalculateSurface());
        Console.WriteLine("\nAnd the same results using array: \n");
        Shape[] shapes = new Shape[3];
        shapes[0] = new Rectangle(4, 6);
        shapes[1] = new Triangle(4, 3);
        shapes[2] = new Circle(3, 3);

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.CalculateSurface());
        }
    }
}