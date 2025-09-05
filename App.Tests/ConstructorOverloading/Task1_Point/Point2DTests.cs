using App.ConstructorOverloading.Task1_Point;

namespace App.Tests.ConstructorOverloading.Task1_Point;

[Category("Required")]
public class Point2DTests
{
    [Test]
    public void DefaultCtor_CreatesOrigin()
    {
        var p = new Point2D();
        Assert.That(p.X, Is.EqualTo(0));
        Assert.That(p.Y, Is.EqualTo(0));
    }

    [Test]
    public void Ctor_WithCoordinates_SetsProperties()
    {
        var p = new Point2D(10, -5);
        Assert.That(p.X, Is.EqualTo(10));
        Assert.That(p.Y, Is.EqualTo(-5));
    }

    [Test]
    public void Ctor_FromString_ParsesWithSpaces()
    {
        var p = new Point2D(" 7 ;  9 ");
        Assert.That(p.X, Is.EqualTo(7));
        Assert.That(p.Y, Is.EqualTo(9));
    }

    [Test]
    public void Ctor_Copy_CopiesValues()
    {
        var a = new Point2D(1, 2);
        var b = new Point2D(a);
        Assert.That(b.X, Is.EqualTo(1));
        Assert.That(b.Y, Is.EqualTo(2));
        Assert.That(b, Is.Not.SameAs(a));
    }

    [Test]
    public void Ctor_FromString_Invalid_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() => new Point2D("oops"));
        Assert.Throws<FormatException>(() => new Point2D("1,2"));
    }

    [Test]
    public void Ctor_FromString_NegativeValues_ParsesCorrectly()
    {
        var p = new Point2D(" -1 ; -2 ");
        Assert.That(p.X, Is.EqualTo(-1));
        Assert.That(p.Y, Is.EqualTo(-2));
    }

    [Test]
    public void Ctor_FromString_NullOrEmpty_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() => new Point2D((string?)null!));
        Assert.Throws<FormatException>(() => new Point2D(string.Empty));
    }

    [Test]
    public void Ctor_FromString_TooManyParts_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() => new Point2D("1;2;3"));
    }
}