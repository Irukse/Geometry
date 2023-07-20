namespace Geometry.Extensions;

public static class DoubleExtensions
{
    /// <summary>
    /// Precision
    /// </summary>
    /// <param name="number"></param>
    /// <param name="precision"></param>
    /// <returns></returns>
    public static double RoundToPrecision(this double number, int precision)
    {
        return Math.Round(number, precision);
    } 
}