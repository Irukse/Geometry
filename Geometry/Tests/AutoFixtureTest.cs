using AutoFixture;
using AutoFixture.AutoMoq;
using Geometry.Services;
using Moq;
using NUnit.Framework;

namespace Geometry.Tests;

public abstract class AutoFixtureTest
{
    protected IFixture Fixture { get; }

    protected internal Mock<Circle> Circles { get; }

    protected internal Mock<Triangle> Triangles { get; }

    protected AutoFixtureTest()
    {
        Fixture = new Fixture().Customize(new AutoMoqCustomization());

        Circles = Fixture.Freeze<Mock<Circle>>();

        Triangles = Fixture.Freeze<Mock<Triangle>>();
    }

    [SetUp]
    protected void SeedData()
    {
        RegisterMock();
    }

    protected virtual void RegisterMock()
    {
        Fixture.Register(() => Circles.Object);
        Fixture.Register(() => Triangles.Object);
    }
}