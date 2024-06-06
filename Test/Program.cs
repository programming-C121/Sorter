using Sorter.Interfaces;
using Sorter.Sortables;
using Sorter.Sorters;
using Test;

ISorter sorter = new MergeSorter();

List<int> list = new List<int> { 100, 2, -20, 0, -2, -20, 1, 34 };
int[] array = new int[]{ 100, 2, -20, 0, -2, -20, 1, 34 };

Console.WriteLine("Unsorted list:");
list.PrintList(); // Método extensor para List<int> en Extensions.cs

Console.WriteLine("Unsorted array:");
array.PrintArray();

ISortable listSortable = new ListSortable(list);
ISortable arraySortable = new ArraySortable(array);

sorter.Sort(listSortable);
sorter.Sort(arraySortable);

Console.WriteLine("Sorted list:");
list.PrintList();

Console.WriteLine("Sorted array:");
array.PrintArray();
