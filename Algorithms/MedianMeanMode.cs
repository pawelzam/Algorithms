namespace Algorithms;
public static class MedianMeanMode
{
    public static (decimal median, decimal mean, decimal mode) Calculate(int[] array)
    {
        var length = array.Length;
        decimal mean = (decimal)array.Sum() / length;

        Array.Sort(array);
        decimal median = length % 2 == 0 ? ((decimal)array[length / 2 - 1] + array[length / 2]) / 2 : array[Convert.ToInt32(length / 2 + 0.5)];
        var mode = array.GroupBy(p => p).OrderByDescending(p => p.Count()).First().Key;
        return (median, mean, mode);
    }
}
