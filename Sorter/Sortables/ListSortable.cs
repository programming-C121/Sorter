using Sorter.Interfaces;

namespace Sorter.Sortables;

public class ListSortable : ISortable
{
    private List<int> _collection;
    public int Count => _collection.Count;

    public ListSortable(List<int> list)
    {
        _collection = list;
    }

    public void SetAt(int index, int value) => _collection[index] = value;

    public int GetAt(int index) => _collection[index];
}