using System;

class Triangle : Shape
{
    public Triangle(double width, double height)
        : base(width, height)
    {

    }

    public override double CalculateSurface()
    {
        double area = (this.Width * this.Height) / 2;
        return area;
    }
}