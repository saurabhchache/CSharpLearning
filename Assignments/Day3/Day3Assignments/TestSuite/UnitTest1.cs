using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day3Assignments;
using System.Collections.Generic;

namespace TestSuite
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToStringOverrideTest()
        {
            Point p = new Point(3, 7);
            Assert.IsNotNull(p.ToString());
            Assert.IsTrue(p.ToString().Length > 0);
        }

        [TestMethod]
        public void DictionaryOperationsTest()
        {
            Dictionary<Point, string> points = new Dictionary<Point, string>();
            Point p1 = new Point(7, 3);
            Point p2 = new Point(7, 3);
            Point p3 = new Point(5, 7);

            points.Add(p1, "pointA");
            points.Add(p3, "pointC");

            Assert.IsTrue(points.Count > 0);

            points.Remove(p3);

            Assert.IsTrue(points.Count == 1);

            points[p1] = "newPoint";

            Assert.IsTrue(string.Equals("newPoint", points[p2], StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void Point_ReflexiveTest()
        {
            Point p = new Point(3, 7);
            Assert.IsTrue(p.Equals(p));
        }
    }
}
