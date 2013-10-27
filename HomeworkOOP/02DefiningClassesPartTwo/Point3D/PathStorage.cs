//4.Create a class Path to hold a sequence of points in the 3D space. 
//Create a static class PathStorage with static methods to save and 
//load paths from a text file. Use a file format of your choice.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security;

namespace Point3D
{
    static class PathStorage
    {
        public static void SavePath(List<StructPoint3D> path)
        {
            StreamWriter writer = new StreamWriter(@"../../PathFile.txt");
            using (writer)
            {
                foreach (var point in path)
                {
                    writer.WriteLine(String.Format("{0} {1} {2}", point.X, point.Y, point.Z));
                }
            }
        }

        public static List<StructPoint3D> LoadPath()
        {
            List<StructPoint3D> loadPath = new List<StructPoint3D>();
 
            try
            {
                StreamReader reader = new StreamReader(@"../../PathFile.txt");

                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {                      
                        StructPoint3D point = new StructPoint3D();
                        string[] points = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        point.X = double.Parse(points[0]);
                        point.Y = double.Parse(points[1]);
                        point.Z = double.Parse(points[2]);
                        loadPath.Add(point);
                        line = reader.ReadLine();
                    }
                }
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path contains a directory that cannot be found!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
            }
            catch (UnauthorizedAccessException uoae)
            {
                Console.WriteLine(uoae.Message);
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have the required permission to access this file!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            return loadPath;
        }
    }
}
