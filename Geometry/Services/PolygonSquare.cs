namespace Geometry.Services;

/// <summary>
/// Initial class for <inheritdoc cref="IFigureCalculation"/>
/// </summary>
public class PolygonSquare : IFigureCalculation
{
    public virtual FigureCalculationResponse GetSquare(FigureCalculationContext context)
    {
        var square = GetCalculateTriangle(context.LengthFigure);
        var result = new FigureCalculationResponse
        {
            Square = square.Item1,
            Rectangular = square.Item2,
        };
        return result;
    }

    private (double, bool) GetCalculateTriangle(IReadOnlyList<double> triangle)
    {
        var min = triangle.Min();
        if (min <= 0)
        {
            throw new ArgumentException("side size must not be less 0");
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

        // is the triangle right angled 
        var shorterSides = triangle
            .TakeWhile(value => value < maxEdge)
            .Select(value => Math.Pow(value, 2))
            .Sum();
        var rectangular = Math.Pow(maxEdge, 2) == shorterSides;

        return (square, rectangular);
    }
}