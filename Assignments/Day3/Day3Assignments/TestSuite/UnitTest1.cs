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

        [TestMethod]
        public void Point_SymmetricTest()
        {
            Point p1 = new Point(3, 7);
            Point p2 = new Point(3, 7);
            Assert.IsTrue(p1.Equals(p2) == p2.Equals(p1));
        }

        [TestMethod]
        public void Point_TransitiveTest()
        {
            Point p1 = new Point(3, 7);
            Point p2 = new Point(3, 7);
            Point p3 = new Point(3, 7);
            Assert.IsTrue(p1.Equals(p2));
            Assert.IsTrue(p2.Equals(p3));
            Assert.IsTrue(p1.Equals(p3));
        }

        [TestMethod]
        public void SimpleCacheTest()
        {
            SimpleCache cache = new SimpleCache();
            cache.Add("point1", new Point(1, 2));
            Assert.IsNotNull(cache["point1"]);
            Assert.IsNotNull(cache.Get("point1"));
            Assert.IsNotNull(cache.Get<Point>("point1"));

            cache.Update("point1", new Point(2, 3));
            Assert.IsTrue(new Point(2, 3).Equals((Point)cache["point1"]));

            cache.Remove("point1");
            Assert.IsNull(cache["point1"]);

            cache.Add("point1", new Point(1, 2));
            cache.Clear();
            Assert.IsNull(cache["point1"]);
        }
    }
}
