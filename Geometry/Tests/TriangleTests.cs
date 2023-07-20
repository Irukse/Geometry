using Geometry.Services;
using NUnit.Framework;

namespace Geometry.Tests;

public class TriangleTests
{
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

        var figure = new Triangle(triangle);

        //Act
        var square = figure.GetSquare(3);
        var rightAngled = figure.GetCalculateRightAngled(triangle);

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
        var figure = new Triangle(triangle);

        //Act
        var square = figure.GetSquare(3);
        var rightAngled = figure.GetCalculateRightAngled(triangle);

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
        var figure = new Triangle(triangle);

        //Assert
        Assert.Throws<ArgumentException>(() => figure.GetSquare(3));
    }
}