// Задача: Перегрузка конструкторов — Point2D
// Реализуйте класс Point2D с несколькими конструкторами согласно README.

namespace App.ConstructorOverloading.Task1_Point;

public class Point2D
{
    // Координаты точки. Сделаны только для чтения снаружи.
    public int X { get; private set; }
    public int Y { get; private set; }

    // Конструктор по умолчанию: (0,0)
    public Point2D()
    {
        throw new NotImplementedException();
    }

    // Конструктор координат
    public Point2D(int x, int y)
    {
        throw new NotImplementedException();
    }

    // Конструктор из строки "x;y" (пробелы допустимы)
    public Point2D(string s)
    {
        throw new NotImplementedException();
    }

    // Конструктор копирования
    public Point2D(Point2D other)
    {
        throw new NotImplementedException();
    }
}