using Geometry.Geometry;
using Microsoft.VisualBasic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.GeometryTest
{
    internal class TriangleTest
    {
        [Test]
        public void GetSquareTest()
        {
            // Data.
            double a = 3d, b = 4d, c = 5d;
            double result = 6d;
            var triangle = new Triangle(a, b, c);

            // Act.
            var square = triangle?.Calc();

            // Assert.
            Assert.NotNull(square);
           
        }
    }
}
