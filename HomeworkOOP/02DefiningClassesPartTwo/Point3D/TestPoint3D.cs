using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point3D
{
    class TestPoint3D
    {
        static void Main(string[] args)
        {
            StructPoint3D point = new StructPoint3D();
            {
                point.X = 4.3;
                point.Y = 6.2;
                point.Z = 2.1;
            }

            Console.WriteLine(point.ToString());
            double dist = Distance.CalculateDistance(point,StructPoint3D.ZeroPoint);
            Console.WriteLine(dist);

            List<StructPoint3D> p = PathStorage.LoadPath();
            foreach (var item in p)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            p.Add(point);
            PathStorage.SavePath(p);
            
            foreach (var item in p)
            {
                Console.WriteLine(item);
            }

        }
    }
}
