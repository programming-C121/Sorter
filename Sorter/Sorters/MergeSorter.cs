using Sorter.Interfaces;
using Sorter.Sortables;

namespace Sorter.Sorters;

public class MergeSorter : ISorter
{
    public void Sort(ISortable sortable)
    {
        var temp = new ArraySortable(new int[sortable.Count]);
        CopyTo(sortable, temp);
        Sort(sortable, temp);
    }

    private void Sort(ISortable sortable, ISortable temp)
    {
        if (sortable.Count <= 1)
        {
            return;
        }

        int middle = sortable.Count / 2;
        var firstSlice = new SliceSortable(temp, 0, middle);
        var secondSlice = new SliceSortable(temp, middle, sortable.Count);
        Sort(firstSlice);
        Sort(secondSlice);
        Merge(sortable, firstSlice, secondSlice);
    }

    private static void CopyTo(ISortable source, ISortable target)
    {
        for (int i = 0; i < source.Count; i++)
        {
            target.SetAt(i, source.GetAt(i));
        }
    }

    private void Merge(ISortable result, ISortable firstSlice, ISortable secondSlice)
    {
        int i = 0; // Index for firstSlice
        int j = 0; // Index for secondSlice
        int k = 0; // Index for result
        while (i < firstSlice.Count && j < secondSlice.Count)
        {
            if (firstSlice.GetAt(i) < secondSlice.GetAt(j))
            {
                result.SetAt(k, firstSlice.GetAt(i));
                i++;
            }
            else
            {
                result.SetAt(k, secondSlice.GetAt(j));
                j++;
            }

            k++;
        }

        while (i < firstSlice.Count)
        {
            result.SetAt(k, firstSlice.GetAt(i));
            i++;
            k++;
        }

        while (j < secondSlice.Count)
        {
            result.SetAt(k, secondSlice.GetAt(j));
            j++;
            k++;
        }
    }
}