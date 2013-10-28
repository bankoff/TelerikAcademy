using System;

class Circle : Shape
{
    public Circle(double width, double height)
        : base(width, height)
    {
        try
        {
            if (this.Width != this.Height)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Width = width;
                this.Height = height;
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Both Values must be equal!!!");
        }
    }

    public override double CalculateSurface()
    {
        double area = (this.Width * Math.PI * Math.PI);
        return area;
    }
}