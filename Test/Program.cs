using Sorter.Interfaces;
using Sorter.Sortables;
using Sorter.Sorters;
using Test;

ISorter sorter = new BubbleSorter();

List<int> list = new List<int> { 100, 2, -20, 0, -2, -20, 1, 34 };
int[] array = new int[]{ 100, 2, -20, 0, -2, -20, 1, 34 };

Console.WriteLine("Unsorted list:");
Utils.PrintList(list);
    
Console.WriteLine("Unsorted array:");
Utils.PrintArray(array);

ISortable listSortable = new ListSortable(list);
ISortable arraySortable = new ArraySortable(array);

sorter.Sort(listSortable);
sorter.Sort(arraySortable);

Console.WriteLine("Sorted list:");
Utils.PrintList(list);

Console.WriteLine("Sorted array:");
Utils.PrintArray(array);
