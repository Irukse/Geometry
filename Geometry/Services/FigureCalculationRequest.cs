namespace Geometry.Services;

/// <summary>
/// Request for <inheritdoc cref="DistributorFigures"/>
/// </summary>
public class FigureCalculationRequest
{
    /// <summary>
    /// Area figure
    /// </summary>
    public double Square { get; set; }

    /// <summary>
    /// is it a right triangle
    /// </summary>
    public bool? Rectangular { get; set; }
}