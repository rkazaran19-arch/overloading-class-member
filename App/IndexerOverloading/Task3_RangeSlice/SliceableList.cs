// Задача: Перегрузка индексаторов — SliceableList<T>
// Реализуйте индексаторы: [int index], [Index], [Range]

using System;
using System.Collections;
using System.Collections.Generic;

namespace App.IndexerOverloading.Task3_RangeSlice;

public class SliceableList<T>
{
    public SliceableList()
    {
        throw new NotImplementedException();
    }

    public SliceableList(IEnumerable<T> source)
    {
        throw new NotImplementedException();
    }

    public int Count => throw new NotImplementedException();

    public T this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public T this[Index index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public SliceableList<T> this[Range range]
    {
        get => throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }
}