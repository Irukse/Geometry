namespace Geometry.Services;

/// <summary>
/// Context for <inheritdoc cref="DistributorFigures"/>
/// </summary>
public class FigureCalculationContext
{
    /// <summary>
    /// Parameters for each side
    /// </summary>
    public List<double>? LengthFigure { get; set; }

    /// <summary>
    /// Radius
    /// </summary>
    public double? Radius { get; set; }
}