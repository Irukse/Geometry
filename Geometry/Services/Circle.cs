using Geometry.Extensions;

namespace Geometry.Services;

public class Circle : Figures
{
    public override double GetSquare(List<double> figure, int precision)
    {
        var radius = figure.FirstOrDefault();
        
        if (radius <= 0.0)
        {
            throw new ArgumentException("radius must not be less 0");
        }
        
        var result = Math.PI * Math.Pow(radius, 2d);
        
      var   resultrr = result.RoundToPrecision(precision);
        
        return resultrr;
    }
}