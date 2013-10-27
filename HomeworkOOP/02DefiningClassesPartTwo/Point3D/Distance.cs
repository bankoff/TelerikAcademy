//3.Write a static class with a static method to calculate the distance between two points in the 3D space.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point3D
{
    static class Distance
    {
        public static double CalculateDistance(StructPoint3D firstPoint, StructPoint3D secondPoint)
        {
            double distance = Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X)
                                        + (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y)
                                        + (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));
            return distance;
        }
    }
}