namespace Geometry.Services;

/// <summary>
/// Initial class for <inheritdoc cref="IFigureCalculation"/>
/// </summary>
public class CircleSquare : IFigureCalculation
{
    public virtual FigureCalculationResponse GetSquare(FigureCalculationContext context)
    {
        if (context.Radius <= 0.0)
        {
            throw new ArgumentException("radius must not be less 0");
        }

        var radius = (double)context.Radius;
        var square = GetCalculateRadius(radius);
        var result = new FigureCalculationResponse
        {
            Square = square
        };

        return result;
    }

    private double GetCalculateRadius(double radius)
    {
        return Math.PI * Math.Pow(radius, 2d);
    }
}