// 1. Refactor the following code to use proper variable naming and simplified expressions:

namespace RotateFigure
{
    using System;

    public class Figure
    {
        private double width;

        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Width should be positive!");
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Height should be positive!");
                }
            }
        }

        public static Figure GetRotatedFigure(Figure rectangle, double angleOfRotation)
        {
            double rotatedWidthSize = (Math.Abs(Math.Cos(angleOfRotation)) * rectangle.Width) + 
                (Math.Abs(Math.Sin(angleOfRotation)) * rectangle.Height);
            double rotatedHeightSize = (Math.Abs(Math.Sin(angleOfRotation)) * rectangle.Width) + 
                (Math.Abs(Math.Cos(angleOfRotation)) * rectangle.Height);
            Figure rotatedFigure = new Figure(rotatedWidthSize, rotatedHeightSize);

            return rotatedFigure;
        }

        public override string ToString()
        {
            string figureToString = string.Empty;
            figureToString = string.Format("Figure width:{0} \nFigure height:{1}", this.Width, this.Height);

            return figureToString;
        }
    }
}