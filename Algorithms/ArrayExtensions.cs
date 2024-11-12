namespace Algorithms;
public static class ArrayExtensions
{
    public static void Print<T>(this T[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }
}
