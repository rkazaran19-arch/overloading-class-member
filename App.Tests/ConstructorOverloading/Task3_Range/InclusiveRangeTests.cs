using App.ConstructorOverloading.Task3_Range;

namespace App.Tests.ConstructorOverloading.Task3_Range;


public class InclusiveRangeTests
{
    [Test]
    public void Ctor_StartEnd_SetsBounds()
    {
        var r = new InclusiveRange(2, 5);
        Assert.That(r.Start, Is.EqualTo(2));
        Assert.That(r.End, Is.EqualTo(5));
    }

    [Test]
    public void Ctor_Single_MakesSingletonRange()
    {
        var r = new InclusiveRange(7);
        Assert.That(r.Start, Is.EqualTo(7));
        Assert.That(r.End, Is.EqualTo(7));
    }

    [Test]
    public void Ctor_FromString_ParsesCorrectly()
    {
        var r = new InclusiveRange("10..20");
        Assert.That(r.Start, Is.EqualTo(10));
        Assert.That(r.End, Is.EqualTo(20));
    }

    [Test]
    public void Ctor_StartGreaterThanEnd_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new InclusiveRange(5, 2));
    }

    [Test]
    public void Ctor_FromString_Invalid_Throws()
    {
        Assert.Throws<FormatException>(() => new InclusiveRange("oops"));
        Assert.Throws<FormatException>(() => new InclusiveRange("1.."));
        Assert.Throws<FormatException>(() => new InclusiveRange("..2"));
    }

    [Test]
    public void Ctor_FromString_WithSpaces_ParsesCorrectly()
    {
        var r = new InclusiveRange("  3..  3  ");
        Assert.That(r.Start, Is.EqualTo(3));
        Assert.That(r.End, Is.EqualTo(3));
    }

    [Test]
    public void Ctor_FromString_StartGreaterThanEnd_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new InclusiveRange("5..3"));
    }
}