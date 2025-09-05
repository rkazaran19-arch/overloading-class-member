using App.ConstructorOverloading.Task2_Matrix;

namespace App.Tests.ConstructorOverloading.Task2_Matrix;


public class IntMatrixTests_Starred
{
    [Test]
    public void Ctor_RowsCols_CreatesZeroFilledMatrix()
    {
        var m = new IntMatrix(2, 3);
        Assert.That(m.RowCount, Is.EqualTo(2));
        Assert.That(m.ColCount, Is.EqualTo(3));
        for (int r = 0; r < m.RowCount; r++)
        for (int c = 0; c < m.ColCount; c++)
            Assert.That(m[r, c], Is.EqualTo(0));
    }

    [Test]
    public void Ctor_FromRectArray_CopiesValues()
    {
        var data = new int[,] { { 1, 2 }, { 3, 4 } };
        var m = new IntMatrix(data);
        Assert.That(m.RowCount, Is.EqualTo(2));
        Assert.That(m.ColCount, Is.EqualTo(2));
        Assert.That(m[0, 0], Is.EqualTo(1));
        Assert.That(m[0, 1], Is.EqualTo(2));
        Assert.That(m[1, 0], Is.EqualTo(3));
        Assert.That(m[1, 1], Is.EqualTo(4));
    }

    [Test]
    public void Ctor_FromJaggedArray_ValidatesRectangular()
    {
        var data = new[] { new[] { 1, 2 }, new[] { 3, 4 } };
        var m = new IntMatrix(data);
        Assert.That(m.RowCount, Is.EqualTo(2));
        Assert.That(m.ColCount, Is.EqualTo(2));
        Assert.That(m[1, 1], Is.EqualTo(4));
    }

    [Test]
    public void Ctor_FromJaggedArray_InvalidRows_Throws()
    {
        var bad = new[] { new[] { 1, 2 }, new[] { 3 } };
        Assert.Throws<ArgumentException>(() => new IntMatrix(bad));
    }

    [Test]
    public void Ctor_InvalidSizes_Throws()
    {
        Assert.Throws<ArgumentException>(() => new IntMatrix(0, 1));
        Assert.Throws<ArgumentException>(() => new IntMatrix(1, 0));
        Assert.Throws<ArgumentException>(() => new IntMatrix(-1, 2));
    }
}