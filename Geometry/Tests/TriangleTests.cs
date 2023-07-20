using AutoFixture;
using Geometry.Services;
using NUnit.Framework;

namespace Geometry.Tests;

public class TriangleTests : AutoFixtureTest
{
    private readonly Triangle _triangle;

    public TriangleTests()
    {
        _triangle = Fixture.Create<Triangle>();;
    }
    
        [Test]
    public void Triangle_DataCorrect_CanBeSuccess_CanBeTriangleRight()
    {
        //Arrange
        var triangle = new List<double>()
        {
            3d,
            4d,
            5d,
        };

        //Act
        var square = _triangle.GetSquare(triangle, 3);
        var rightAngled = _triangle.GetCalculateRightAngled(triangle);
        
        //Assert
        Assert.AreEqual(6, square);
        Assert.AreEqual(true, rightAngled);
    }

    [Test]
    public void Triangle_DataCorrect_CanBeSuccess()
    {
        //Arrange
        var triangle = new List<double>()
        {
            4d,
            4d,
            5d,
        };
        
        //Act
        var square = _triangle.GetSquare(triangle, 3);
        var rightAngled = _triangle.GetCalculateRightAngled(triangle);

        //Assert
        Assert.AreEqual(7.806d, square);
        Assert.AreEqual(false, rightAngled);
    }

    [Test]
    public void Triangle_LenghtException_ThrowsException()
    {
        //Arrange
        var triangle = new List<double>()
        {
            3d,
            4d,
            5d,
            6d,
        };

        //Assert
        Assert.Throws<ArgumentException>(() => _triangle.GetSquare(triangle, 3));
    }
}