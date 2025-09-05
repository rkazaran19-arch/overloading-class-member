using App.MethodOverloading.Task1_SumOverloads;

namespace App.Tests.MethodOverloading.Task1_SumOverloads;


public class SumUtilTests
{
    [Test]
    public void Sum_TwoInts_ReturnsSum()
    {
        Assert.That(SumUtil.Sum(1, 2), Is.EqualTo(3));
    }

    [Test]
    public void Sum_ThreeInts_ReturnsSum()
    {
        Assert.That(SumUtil.Sum(1, 2, 3), Is.EqualTo(6));
    }

    [Test]
    public void Sum_Params_ReturnsSum()
    {
        Assert.That(SumUtil.Sum(1, 2, 3, 4), Is.EqualTo(10));
    }

    [Test]
    public void Sum_EmptyOrNull_ReturnsZero()
    {
        Assert.That(SumUtil.Sum(Array.Empty<int>()), Is.EqualTo(0));
        Assert.That(SumUtil.Sum(null!), Is.EqualTo(0));
    }

    [Test]
    public void Sum_IntArray_ReturnsSum()
    {
        Assert.That(SumUtil.Sum(new int[]{4, 5, 6}), Is.EqualTo(15));
    }

    [Test]
    public void Sum_NoParams_ReturnsZero()
    {
        Assert.That(SumUtil.Sum(), Is.EqualTo(0));
    }

    [Test]
    public void Sum_WithNegativeNumbers_Works()
    {
        Assert.That(SumUtil.Sum(-1, -2, -3), Is.EqualTo(-6));
        Assert.That(SumUtil.Sum(-1, 2), Is.EqualTo(1));
    }
}