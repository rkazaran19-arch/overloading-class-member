using App.IndexerOverloading.Task1_SimpleDictionary;

namespace App.Tests.IndexerOverloading.Task1_SimpleDictionary;


public class MultiKeyDictionaryTests
{
    [Test]
    public void Get_MissingKey_Throws()
    {
        var dict = new MultiKeyDictionary();
        Assert.Throws<KeyNotFoundException>(() => { var _ = dict["x"]; });
        Assert.Throws<KeyNotFoundException>(() => { var _ = dict["cat", "x"]; });
    }

    [Test]
    public void SetAndGet_BySingleKey_Works()
    {
        var dict = new MultiKeyDictionary();
        dict["a"] = 10;
        Assert.That(dict["a"], Is.EqualTo(10));
    }

    [Test]
    public void SetAndGet_ByCategoryAndKey_Works()
    {
        var dict = new MultiKeyDictionary();
        dict["math", "pi"] = 314;
        dict["phys", "pi"] = 3;
        Assert.That(dict["math", "pi"], Is.EqualTo(314));
        Assert.That(dict["phys", "pi"], Is.EqualTo(3));
    }
}