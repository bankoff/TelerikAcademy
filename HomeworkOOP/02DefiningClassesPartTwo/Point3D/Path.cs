//4.Create a class Path to hold a sequence of points in the 3D space. 
//Create a static class PathStorage with static methods to save and 
//load paths from a text file. Use a file format of your choice.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point3D
{
    class Path
    {
        public IList<StructPoint3D> Points { get; set; }

        public Path()
        {
            this.Points = new List<StructPoint3D>();
        }
    }
}