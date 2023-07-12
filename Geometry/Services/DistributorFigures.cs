using Geometry.Enums;

namespace Geometry.Services;

/// <summary>
/// Shape definition layer
/// </summary>
public class DistributorFigures
{
    private readonly CircleSquare _circle;
    private readonly PolygonSquare _polygon;

    public DistributorFigures(CircleSquare circle, PolygonSquare polygon)
    {
        _circle = circle;
        _polygon = polygon;
    }

    public FigureCalculationRequest GetFigureArea(FigureCalculationContext context)
    {
        if (context.Radius != null)
        {
            return _circle.GetSquare(context);
        }

        if (context.LengthFigure is { Count: (int)Figure.Triangle })
        {
            return _polygon.GetSquare(context);
        }

        throw new ArgumentException("figure not found");
    }
}