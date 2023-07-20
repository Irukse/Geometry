using AutoFixture;
using Geometry.Extensions;
using Geometry.Services;
using NUnit.Framework;

namespace Geometry.Tests;

public class CircleTests : AutoFixtureTest
{
    private readonly Circle _circle;

    public CircleTests()
    {
        _circle = Fixture.Create<Circle>();
    }
    
    [Test]
    public void Circle_RadiusNotNull_CanBeSuccess()
    {
        //Arrange
        var figure = new List<double>() { 3d };

        //Act
        var result = _circle.GetSquare(figure, 3);
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
        //Arrange
        var figure = new List<double>() { radius };

        //Assert
        Assert.Throws<ArgumentException>(() => _circle.GetSquare(figure, 3));
    }
}