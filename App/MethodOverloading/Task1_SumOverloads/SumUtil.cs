// Задача: Перегрузка методов — Sum
// Реализуйте набор перегруженных методов Sum согласно описанию в README.
// Подсказка: обратите внимание на конфликт между перегрузками с массивом и params.

namespace App.MethodOverloading.Task1_SumOverloads;

public static class SumUtil
{
    // Складывает два int
    public static int Sum(int a, int b)
    {
        throw new NotImplementedException();
    }

    // Складывает три int
    public static int Sum(int a, int b, int c)
    {
        throw new NotImplementedException();
    }

    // Складывает произвольное количество значений
    public static int Sum(params int[] values)
    {
        throw new NotImplementedException();
    }
}