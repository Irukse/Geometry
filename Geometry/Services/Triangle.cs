using Geometry.Extensions;
using Geometry.Library;

namespace Geometry.Services;

/// <summary>
/// Figure triangle
/// </summary>
public class Triangle : Figures
{
    private List<double> _triangleFigure;

    public Triangle(List<double> triangleFigure)
    {
        if (triangleFigure.Count != 3 )
        {
            throw new ArgumentException("The number of sides must be three");
        }
        
        var min = triangleFigure.Min();
        if (min <= 0)
        {
            throw new ArgumentException("Side size must not be less 0");
        }

        var maxEdge = triangleFigure.Max();
        var perimeter = triangleFigure.Sum();

        if (maxEdge > (perimeter - maxEdge))
        {
            throw new ArgumentException(
                "The longest side of the triangle must be less than the sum of the other sides");
        }
        
        _triangleFigure = triangleFigure;
    }
    
    /// <inheritdoc />
    public override double GetSquare(int precision)
    {
        var square = GetSquareTriangle(_triangleFigure);
        square = square.RoundToPrecision(precision);
        
        return square;
    }
    
    /// <summary>
    /// Triangle squareness test method
    /// </summary>
    /// <param name="triangle"></param>
    /// <returns></returns>
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
    
    /// <summary>
    /// Get square for triangle on both sides
    /// </summary>
    /// <param name="triangle"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private double GetSquareTriangle(List<double> triangle)
    {
        var semiPerimeter = triangle.Sum() / 2d;
        var square = Math.Sqrt(
            semiPerimeter *
            triangle.Select(x => semiPerimeter - x).Aggregate((x, y) => x * y));

        return square;
    }
}