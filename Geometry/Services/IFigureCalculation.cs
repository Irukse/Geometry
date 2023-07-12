namespace Geometry.Services;

/// <summary>
/// Interface for get area figures
/// </summary>
public interface IFigureCalculation
{
    /// <summary>
    /// Get area of figure depending on context
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public FigureCalculationRequest GetSquare(FigureCalculationContext context);
}