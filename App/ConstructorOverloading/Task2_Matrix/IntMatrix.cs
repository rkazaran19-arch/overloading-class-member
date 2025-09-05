// Задача: Перегрузка конструкторов — IntMatrix
// Реализуйте класс IntMatrix с перегруженными конструкторами согласно README.
// Рекомендуется использовать цепочки конструкторов для устранения дублирования кода.

namespace App.ConstructorOverloading.Task2_Matrix;

public class IntMatrix
{
    // Размеры матрицы
    public int RowCount { get; }
    public int ColCount { get; }

    // Индексатор для проверки значений в тестах
    public int this[int row, int col]
    {
        get => throw new NotImplementedException();
    }

    // Конструктор (rows, cols) — заполняет нулями
    public IntMatrix(int rows, int cols)
    {
        throw new NotImplementedException();
    }

    // Конструктор из прямоугольного массива
    public IntMatrix(int[,] data)
    {
        throw new NotImplementedException();
    }

    // Конструктор из ступенчатого массива (все строки должны быть одинаковой длины)
    public IntMatrix(int[][] data)
    {
        throw new NotImplementedException();
    }
}