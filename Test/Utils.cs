using System.Diagnostics;
using Sorter.Interfaces;

namespace Test;

public static class Utils
{
    public static long TimeSorting(ISorter sorter, ISortable sortable)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        sorter.Sort(sortable);
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
}