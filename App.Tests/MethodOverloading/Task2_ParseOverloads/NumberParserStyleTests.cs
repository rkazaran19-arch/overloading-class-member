using System.Globalization;
using App.MethodOverloading.Task2_ParseOverloads;

namespace App.Tests.MethodOverloading.Task2_ParseOverloads;

[Category("Additional")]
public class NumberParserStyleTests_Starred
{
    [Test]
    public void Parse_WithStyleAndCulture_AllowsThousands()
    {
        var culture = new CultureInfo("ru-RU");
        Assert.That(NumberParser.Parse("1 234", NumberStyles.AllowThousands, culture), Is.EqualTo(1234));
    }
}
