using Geometry.Extensions;
using Geometry.Services;
using NUnit.Framework;

namespace Geometry.Tests;

public class CircleTests
{
    [Test]
    public void Circle_RadiusNotNull_CanBeSuccess()
    {
        //Arrange
        var radius = 3;
        var figure = new Circle(radius);

        //Act
        var result = figure.GetSquare(3);
        var expectedValue = Math.PI * Math.Pow(3, 2d);

        expectedValue = expectedValue.RoundToPrecision(3);

        //Assert
        Assert.NotNull(result);
        Assert.AreEqual(expectedValue, result);
    }

    [TestCase(0)]
    [TestCase(-1)]
    public void Circle_NegativeRadius_ThrowsException(double radius)
    {
        //Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}