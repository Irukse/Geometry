using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Geometry
{
    internal class Triangle : ICalculate
    {
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }

        /// <exception cref="ArgumentException"></exception>
        
        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;

            var maxEdge = Math.Max(edgeA, Math.Max(edgeB, edgeC));
            var perimeter = edgeA + edgeB + edgeC;
            if ( maxEdge > (perimeter - maxEdge))
                throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы других сторон");

   
        }

        public double Calc()
        {
            var halfP = (EdgeA + EdgeB + EdgeC) / 2d;
            var square = Math.Sqrt(
                halfP
                * (halfP - EdgeA)
                * (halfP - EdgeB)
                * (halfP - EdgeC)
            );

            return square;
        }

    }
}

