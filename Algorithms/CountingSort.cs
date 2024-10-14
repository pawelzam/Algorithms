namespace Algorithms;
public static class CountingSort
{
    public static List<int> Sort(List<int> arr)
    {
        var array = new int[arr.Count()];

        for (var i = 0; i < arr.Count; i++)
        {
            var value = arr[i];
            if (value < array.Length)
                array[value]++;
        }

        return array.ToList();
    }
}
