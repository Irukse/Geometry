using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Geometry
{
    internal class Circle : ICalculate
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Calc()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
