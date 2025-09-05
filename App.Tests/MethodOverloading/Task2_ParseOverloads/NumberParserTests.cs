using System.Globalization;
using App.MethodOverloading.Task2_ParseOverloads;

namespace App.Tests.MethodOverloading.Task2_ParseOverloads;

[Category("Required")]
public class NumberParserTests
{
    [Test]
    public void Parse_StringValid_ReturnsInt()
    {
        Assert.That(NumberParser.Parse("42"), Is.EqualTo(42));
    }

    [Test]
    public void Parse_StringInvalid_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() => NumberParser.Parse("abc"));
    }

    [Test]
    public void Parse_WithDefaultValue_Invalid_ReturnsDefault()
    {
        Assert.That(NumberParser.Parse("abc", 7), Is.EqualTo(7));
    }

    [Test]
    public void Parse_StringWithWhitespace_ReturnsInt()
    {
        Assert.That(NumberParser.Parse("  123  "), Is.EqualTo(123));
    }

    [Test]
    public void Parse_WithDefaultValue_ValidString_ReturnsParsedValue()
    {
        Assert.That(NumberParser.Parse("10", 5), Is.EqualTo(10));
    }

    [Test]
    public void Parse_SignedNumber_ReturnsCorrect()
    {
        Assert.That(NumberParser.Parse("+7"), Is.EqualTo(7));
        Assert.That(NumberParser.Parse("-8"), Is.EqualTo(-8));
    }
}