namespace CohesionAndCoupling
{
    using System;

    public class RectangularParallelepiped
    {
        private double width;
        private double height;
        private double depth;

        public RectangularParallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
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
                    throw new ArgumentOutOfRangeException("Invalid input data. Width must be positive!");
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
                    throw new ArgumentOutOfRangeException("Invalid input data. Height must be positive!");
                }
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value > 0)
                {
                    this.depth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid input data. Depth must be positive!");
                }
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;

            return volume;
        }

        public double CalcBodyDiagonal()
        {
            double distance = Calculate.Distance3D(0, 0, 0, this.Width, this.Height, this.Depth);

            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = Calculate.Distance2D(0, 0, this.Width, this.Height);

            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = Calculate.Distance2D(0, 0, this.Width, this.Depth);

            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = Calculate.Distance2D(0, 0, this.Height, this.Depth);

            return distance;
        }
    }
}