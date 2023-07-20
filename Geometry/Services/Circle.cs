using Geometry.Extensions;
using Geometry.Library;

namespace Geometry.Services;

/// <summary>
/// Figure circle
/// </summary>
public class Circle : Figures
{
    private double _circleRadius;

    public Circle(double circleRadius)
    {
        if (circleRadius <= 0.0)
        {
            throw new ArgumentException("radius must not be less 0");
        }
        this._circleRadius = circleRadius;
    }
    
    /// <inheritdoc />
    public override double GetSquare(int precision)
    {
        var result = GetSquareCircle(_circleRadius);
        result = result.RoundToPrecision(precision);
        
        return result;
    }

    /// <summary>
    /// Get square for circle from radius
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private double GetSquareCircle(double radius)
    {
        return Math.PI * Math.Pow(radius, 2d);
    }
}