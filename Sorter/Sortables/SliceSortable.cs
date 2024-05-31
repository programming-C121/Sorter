using Sorter.Interfaces;

namespace Sorter.Sortables;

public class SliceSortable : ISortable
{
    private ISortable _sortable;
    private int _start;
    private int _end;
    public int Count => _end - _start;
    
    /// <param name="sortable"> The sortable to be fragmented </param>
    /// <param name="start"> The start index of the fragment inclusive </param>
    /// <param name="end"> The end index of the fragment exclusive </param>
    public SliceSortable(ISortable sortable, int start, int end)
    {
        _sortable = sortable;
        _start = start;
        _end = end;
    }
    
    public void SetAt(int index, int value)
    {
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException();
        }
        _sortable.SetAt(index + _start, value);
    }

    public int GetAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException();
        }
        return _sortable.GetAt(index + _start);
    }
}