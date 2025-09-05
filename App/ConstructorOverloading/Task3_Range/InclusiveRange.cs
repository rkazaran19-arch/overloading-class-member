// Задача: Перегрузка конструкторов — InclusiveRange
// Реализуйте класс InclusiveRange согласно README. Диапазон включительный.

namespace App.ConstructorOverloading.Task3_Range;

public class InclusiveRange
{
    public int Start { get; private set; }
    public int End { get; private set; }

    // Конструктор (start, end)
    public InclusiveRange(int start, int end)
    {
        throw new NotImplementedException();
    }

    // Конструктор из строки "start..end"
    public InclusiveRange(string s)
    {
        throw new NotImplementedException();
    }

    // Конструктор из одного числа
    public InclusiveRange(int single)
    {
        throw new NotImplementedException();
    }
}