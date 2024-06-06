using System.Diagnostics;
using Sorter.Interfaces;

namespace Test;

public static class Extensions
{
    public static void PrintArray(this int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    
    public static void PrintList(this List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }
}