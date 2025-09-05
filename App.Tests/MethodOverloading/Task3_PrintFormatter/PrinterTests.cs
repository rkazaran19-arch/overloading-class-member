using System.Globalization;
using App.MethodOverloading.Task3_PrintFormatter;
using System.Collections.Generic;

namespace App.Tests.MethodOverloading.Task3_PrintFormatter;

[Category("Additional")]
public class PrinterTests_Starred
{
    [Test]
    public void Print_Int_ReturnsNumberAsString()
    {
        Assert.That(Printer.Print(5), Is.EqualTo("5"));
    }

    [Test]
    public void Print_DoubleWithDecimals_UsesInvariantCulture()
    {
        // Ожидается, что реализация использует CultureInfo.InvariantCulture
        Assert.That(Printer.Print(3.14159, 2), Is.EqualTo("3.14"));
    }

    [Test]
    public void Print_Params_Ints_CommaSeparated()
    {
        Assert.That(Printer.Print(1, 2, 3), Is.EqualTo("1,2,3"));
    }

    [Test]
    public void Print_Generic_Empty_ReturnsEmptyMarker()
    {
        Assert.That(Printer.Print(Array.Empty<int>()), Is.EqualTo("<empty>"));
    }

    [Test]
    public void Print_Generic_NonEmpty_ReturnsCommaSeparated()
    {
        var items = new List<string> { "a", "b", "c" };
        Assert.That(Printer.Print(items), Is.EqualTo("a,b,c"));
    }

    [Test]
    public void Print_DoubleZeroDecimals_ReturnsIntegerPart()
    {
        Assert.That(Printer.Print(2.718, 0), Is.EqualTo("3"));
    }

    [Test]
    public void Print_Double_NegativeValue_RoundsCorrectly()
    {
        Assert.That(Printer.Print(-1.2345, 3), Is.EqualTo("-1.235"));
    }

    [Test]
    public void Print_NoParams_ReturnsEmptyMarker()
    {
        Assert.That(Printer.Print(), Is.EqualTo("<empty>"));
    }
}