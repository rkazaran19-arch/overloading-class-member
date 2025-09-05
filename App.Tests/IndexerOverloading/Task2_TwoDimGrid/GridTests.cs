using App.IndexerOverloading.Task2_TwoDimGrid;

namespace App.Tests.IndexerOverloading.Task2_TwoDimGrid;


public class GridTests
{
    [Test]
    public void Indexer_RowCol_SetGet_Works()
    {
        var g = new Grid<int>(2, 3);
        g[0, 1] = 42;
        Assert.That(g[0, 1], Is.EqualTo(42));
    }

    [Test]
    public void Indexer_ByCell_EquivalentToRowCol()
    {
        var g = new Grid<string>(2, 2);
        g[0, 0] = "a";
        Assert.That(g[new Cell(0, 0)], Is.EqualTo("a"));
        g[new Cell(1, 1)] = "b";
        Assert.That(g[1, 1], Is.EqualTo("b"));
    }

    [Test]
    public void Indexer_OneDim_RowMajor_Works()
    {
        var g = new Grid<int>(2, 3);
        g[0, 2] = 7;   // index 2
        g[1, 0] = 9;   // index 3
        Assert.That(g[2], Is.EqualTo(7));
        Assert.That(g[3], Is.EqualTo(9));
    }

    [Test]
    public void Indexer_OutOfRange_Throws()
    {
        var g = new Grid<int>(2, 2);
        Assert.Throws<IndexOutOfRangeException>(() => { var _ = g[-1, 0]; });
        Assert.Throws<IndexOutOfRangeException>(() => { var _ = g[0, -1]; });
        Assert.Throws<IndexOutOfRangeException>(() => { var _ = g[2, 0]; });
        Assert.Throws<IndexOutOfRangeException>(() => { var _ = g[0, 2]; });
        Assert.Throws<IndexOutOfRangeException>(() => { var _ = g[-1]; });
        Assert.Throws<IndexOutOfRangeException>(() => { var _ = g[4]; });
    }
}