using Sorter.Interfaces;

namespace Sorter.Sortables;

public class ArraySortable : ISortable
{
    private int[] _collection;
    public int Count => _collection.Length;

    public ArraySortable(int[] array)
    {
        _collection = array;
    }

    public void SetAt(int index, int value) => _collection[index] = value;

    public int GetAt(int index) => _collection[index];
}