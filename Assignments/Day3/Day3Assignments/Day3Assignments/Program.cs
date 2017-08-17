using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignments
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1
            Point p = new Point(3, 7);
            Console.WriteLine(p.ToString());

            //Assignment 2
            Dictionary<Point, string> points = new Dictionary<Point, string>();
            Point p1 = new Point(7, 3);
            Point p2 = new Point(7, 3);
            Point p3 = new Point(3, 7);
            points.Add(p1, "point1");
            points.Add(p3, "point3");

            Console.ReadKey();
        }
    }
}
