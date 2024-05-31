namespace Sorter.Interfaces;

public interface ISortable
{
    public int Count { get; }
    
    /// <summary>
    /// Sets the value at the specified index.
    /// </summary>
    /// <param name="index"> The index to set the value at </param>
    /// <param name="value"> The value to set </param>
    /// <exception cref="IndexOutOfRangeException"> Thrown when the index is out of range </exception>
    public void SetAt(int index, int value);
    
    /// <summary>
    /// Gets the value at the specified index.
    /// </summary>
    /// <param name="index"> The index to get the value from </param>
    /// <returns> The value at the specified index </returns>
    /// <exception cref="IndexOutOfRangeException"> Thrown when the index is out of range </exception>
    public int GetAt(int index);
}