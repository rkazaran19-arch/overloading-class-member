// filepath: App.Tests/IndexerOverloading/Task4_ArrayWrapper/ArrayWrapperTests.cs
using System;
using App.IndexerOverloading.Task4_ArrayWrapper;

namespace App.Tests.IndexerOverloading.Task4_ArrayWrapper;

public class ArrayWrapperTests
{
    [Test]
    public void Constructor_Null_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new ArrayWrapper<int>(null!));
    }

    [Test]
    public void Length_ReturnsCorrectLength()
    {
        var wrapper = new ArrayWrapper<string>(new[] { "a", "b", "c" });
        Assert.That(wrapper.Length, Is.EqualTo(3));
    }

    [Test]
    public void Get_ValidIndex_ReturnsItem()
    {
        var wrapper = new ArrayWrapper<int>(new[] { 10, 20, 30 });
        Assert.That(wrapper[0], Is.EqualTo(10));
        Assert.That(wrapper[1], Is.EqualTo(20));
        Assert.That(wrapper[2], Is.EqualTo(30));
    }

    [Test]
    public void Set_ValidIndex_UpdatesItem()
    {
        var wrapper = new ArrayWrapper<int>(new[] { 1, 2, 3 });
        wrapper[1] = 42;
        Assert.That(wrapper[1], Is.EqualTo(42));
    }

    [Test]
    public void Get_InvalidIndex_ThrowsIndexOutOfRangeException()
    {
        var wrapper = new ArrayWrapper<int>(new int[2]);
        Assert.Throws<IndexOutOfRangeException>(() => { var _ = wrapper[-1]; });
        Assert.Throws<IndexOutOfRangeException>(() => { var _ = wrapper[2]; });
    }

    [Test]
    public void Set_InvalidIndex_ThrowsIndexOutOfRangeException()
    {
        var wrapper = new ArrayWrapper<int>(new int[2]);
        Assert.Throws<IndexOutOfRangeException>(() => wrapper[-1] = 5);
        Assert.Throws<IndexOutOfRangeException>(() => wrapper[2] = 5);
    }
}
