using Geometry.Geometry;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry.GeometryTest
{
    internal class CircleTest
    {
        private double eps = 1e-7;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ZeroRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0d));
        }


        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1d));
        }

        [Test]
        public void GetSquareTest()
        {
            var radius = 5;
            var circle = new Circle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2d);

            var square = circle.Calc();

            Assert.Less(Math.Abs(square - expectedValue), eps);
        }
    }
}
