using Sorter.Interfaces;

namespace Sorter.Sorters;

public class BubbleSorter : ISorter
{
    public void Sort(ISortable sortable)
    {
        var hasChanges = true;
        for (int i = 0; i < sortable.Count && hasChanges; i++)
        {
            hasChanges = false;
            for (int j = 0; j < sortable.Count - 1; j++)
            {
                if (sortable.GetAt(j) > sortable.GetAt(j + 1))
                {
                    int temp = sortable.GetAt(j);
                    sortable.SetAt(j, sortable.GetAt(j + 1));
                    sortable.SetAt(j + 1, temp);
                    hasChanges = true;
                }
            }
        }
    }
}