using Geometry.Extensions;

namespace Geometry.Services;

public class Triangle : Figures
{
    public override double GetSquare(List<double> triangle, int precision)
    {
        if (triangle.Count != 3 )
        {
            throw new ArgumentException("The number of sides must be three");
        }
        
        var min = triangle.Min();
        if (min <= 0)
        {
            throw new ArgumentException("Side size must not be less 0");
        }

        var maxEdge = triangle.Max();
        var perimeter = triangle.Sum();

        if (maxEdge > (perimeter - maxEdge))
        {
            throw new ArgumentException(
                "The longest side of the triangle must be less than the sum of the other sides");
        }

        var semiPerimeter = triangle.Sum() / 2d;
        var square = Math.Sqrt(
            semiPerimeter *
            triangle.Select(x => semiPerimeter - x).Aggregate((x, y) => x * y));
        
        square = square.RoundToPrecision(precision);
        return square;
    }
    
    public bool GetCalculateRightAngled(List<double> triangle)
    {
        var maxEdge = triangle.Max();
        
        // is the triangle right angled 
        var shorterSides = triangle
            .TakeWhile(value => value < maxEdge)
            .Select(value => Math.Pow(value, 2))
            .Sum();

        return Math.Pow(maxEdge, 2) == shorterSides;
    }
}