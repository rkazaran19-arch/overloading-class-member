// Задача: Перегрузка индексаторов — ArrayWrapper<T>
// Реализуйте класс ArrayWrapper<T> согласно описанию в README.

using System;

namespace App.IndexerOverloading.Task4_ArrayWrapper;

public class ArrayWrapper<T>
{
    private readonly T[] _items;

    // Конструктор принимает массив; при null кидает ArgumentNullException
    public ArrayWrapper(T[] items)
    {
        throw new NotImplementedException();
    }

    // Длина массива
    public int Length => throw new NotImplementedException();

    // Индексатор для чтения/записи с проверкой границ
    public T this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}
