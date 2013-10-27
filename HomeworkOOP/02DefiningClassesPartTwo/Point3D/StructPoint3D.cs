//1.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
//Implement the ToString() to enable printing a 3D point.
//2.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
//Add a static property to return the point O.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point3D
{
    struct StructPoint3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public StructPoint3D(double x, double y, double z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        private static readonly StructPoint3D zeroPoint = new StructPoint3D(0, 0, 0);

        public static StructPoint3D ZeroPoint
        {
            get
            {
                return zeroPoint;
            }
        }

        public override string ToString()
        {
            string pointAsString = string.Format("X:{0}   Y:{1}   Z:{2}", this.X, this.Y, this.Z);
            return pointAsString;
        }
    }
}
