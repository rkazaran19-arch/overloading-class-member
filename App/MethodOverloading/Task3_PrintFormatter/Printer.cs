// Задача: Перегрузка методов — Print
// Реализуйте перегруженные методы Print согласно README. Методы должны возвращать строку.

using System.Collections.Generic;

namespace App.MethodOverloading.Task3_PrintFormatter;

public static class Printer
{
    public static string Print(int value)
    {
        throw new NotImplementedException();
    }

    public static string Print(double value, int decimals)
    {
        throw new NotImplementedException();
    }

    public static string Print(params int[] values)
    {
        throw new NotImplementedException();
    }

    public static string Print<T>(IEnumerable<T> values)
    {
        throw new NotImplementedException();
    }
}