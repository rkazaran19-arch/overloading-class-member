using App.IndexerOverloading.Task3_RangeSlice;

namespace App.Tests.IndexerOverloading.Task3_RangeSlice;


public class SliceableListTests_Starred
{
    [Test]
    public void Indexer_Int_SetGet_Works()
    {
        var list = new SliceableList<int>(new[] { 1, 2, 3 });
        Assert.That(list[1], Is.EqualTo(2));
        list[1] = 5;
        Assert.That(list[1], Is.EqualTo(5));
    }

    [Test]
    public void Indexer_FromEnd_UsingIndex_Works()
    {
        var list = new SliceableList<string>(new[] { "a", "b", "c" });
        Assert.That(list[^1], Is.EqualTo("c"));
        Assert.That(list[^2], Is.EqualTo("b"));
        list[^1] = "z";
        Assert.That(list[2], Is.EqualTo("z"));
    }

    [Test]
    public void Indexer_Range_ReturnsSubList()
    {
        var list = new SliceableList<int>(new[] { 10, 20, 30, 40, 50 });
        var sub = list[1..4];
        Assert.That(sub.Count, Is.EqualTo(3));
        Assert.That(sub[0], Is.EqualTo(20));
        Assert.That(sub[2], Is.EqualTo(40));
    }

    [Test]
    public void Indexer_OutOfRange_Throws()
    {
        var list = new SliceableList<int>(new[] { 1, 2, 3 });
        Assert.Throws<IndexOutOfRangeException>(() => { var _ = list[-1]; });
        Assert.Throws<IndexOutOfRangeException>(() => { var _ = list[3]; });
    }
}