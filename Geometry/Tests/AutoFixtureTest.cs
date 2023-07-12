using AutoFixture;
using AutoFixture.AutoMoq;
using Geometry.Services;
using Moq;
using NUnit.Framework;

namespace Geometry.Tests;

public abstract class AutoFixtureTest
{
    protected IFixture Fixture { get; }
    protected internal Mock<DistributorFigures> Distributor { get; }
    protected internal Mock<CircleSquare> CircleSquare { get; }

    protected internal Mock<PolygonSquare> PolygonSquare { get; }

    protected AutoFixtureTest()
    {
        Fixture = new Fixture().Customize(new AutoMoqCustomization());
        Distributor = Fixture.Freeze<Mock<DistributorFigures>>();
        CircleSquare = Fixture.Freeze<Mock<CircleSquare>>();
        PolygonSquare = Fixture.Freeze<Mock<PolygonSquare>>();
    }

    [SetUp]
    protected void SeedData()
    {
        RegisterMock();
    }

    protected virtual void RegisterMock()
    {
        Fixture.Register(() => Distributor.Object);
        Fixture.Register(() => CircleSquare.Object);
        Fixture.Register(() => PolygonSquare.Object);
    }
}