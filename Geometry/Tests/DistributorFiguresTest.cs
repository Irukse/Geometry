using AutoFixture;
using Geometry.Services;
using NUnit.Framework;

namespace Geometry.Tests;

public class DistributorFiguresTest : AutoFixtureTest
{
    private double _radius = 3;
    private readonly DistributorFigures _story;

    public DistributorFiguresTest()
    {
        _story = Fixture.Create<DistributorFigures>();
    }

    [Test]
    public void DistributorFigures_RadiusNotNull_CanBeSuccess()
    {
        //Arrange
        var context = Fixture.Build<FigureCalculationContext>()
            .With(property => property.Radius, _radius)
            .Without(property => property.LengthFigure)
            .Create();

        //Act
        var result = _story.GetFigureArea(context);
        var expectedValue = Math.PI * Math.Pow(_radius, 2d);

        //Assert
        Assert.NotNull(result);
        Assert.AreEqual(expectedValue, result.Square);
    }

    [TestCase(0)]
    [TestCase(-1)]
    public void DistributorFigures_NegativeRadius_ThrowsException(double radius)
    {
        //Arrange
        var context = Fixture.Build<FigureCalculationContext>()
            .With(property => property.Radius, radius)
            .Without(property => property.LengthFigure)
            .Create();

        //Assert
        Assert.Throws<ArgumentException>(() => _story.GetFigureArea(context));
    }

    [Test]
    public void DistributorFigures_ListNotNull_CanBeTriangleRight()
    {
        //Arrange
        var triangle = new List<double>()
        {
            3d,
            4d,
            5d,
        };
        var context = Fixture.Build<FigureCalculationContext>()
            .Without(property => property.Radius)
            .With(property => property.LengthFigure, triangle)
            .Create();

        //Act
        var result = _story.GetFigureArea(context);

        //Assert
        Assert.NotNull(result);
        Assert.AreEqual(6, result.Square);
        Assert.AreEqual(true, result.Rectangular);
    }

    [Test]
    public void DistributorFigures_ListNotNull_CanBeSuccess()
    {
        //Arrange
        var triangle = new List<double>()
        {
            4d,
            4d,
            5d,
        };
        var context = Fixture.Build<FigureCalculationContext>()
            .Without(property => property.Radius)
            .With(property => property.LengthFigure, triangle)
            .Create();

        //Act
        var result = _story.GetFigureArea(context);

        //Assert
        Assert.NotNull(result);
        Assert.AreEqual(7.8062474979979974d, result.Square);
        Assert.AreEqual(false, result.Rectangular);
    }

    [Test]
    public void DistributorFigures_ListLong_ThrowsException()
    {
        //Arrange
        var triangle = new List<double>()
        {
            3d,
            4d,
            5d,
            6d,
        };
        var context = Fixture.Build<FigureCalculationContext>()
            .Without(property => property.Radius)
            .With(property => property.LengthFigure, triangle)
            .Create();

        //Assert
        Assert.Throws<ArgumentException>(() => _story.GetFigureArea(context));
    }

    [Test]
    public void DistributorFigures_ContextNotCorrect_ThrowsException()
    {
        //Arrange
        var context = Fixture.Build<FigureCalculationContext>()
            .Without(property => property.Radius)
            .Without(property => property.LengthFigure)
            .Create();

        //Assert
        Assert.Throws<ArgumentException>(() => _story.GetFigureArea(context));
    }
}