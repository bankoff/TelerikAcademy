using System;

abstract class Shape
{
    private double width;
    private double height;

    protected double Width
    {
        get { return width; }
        set { width = value; }
    }

    protected double Height
    {
        get { return height; }
        set { height = value; }
    }

    protected Shape(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public virtual double CalculateSurface()
    {
        double area = this.Width * this.Height;
        return area;
    }
}