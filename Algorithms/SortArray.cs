namespace Algorithms;

// Sorting without using Array.Sort()
public static class SortArray
{
    
    public static int[] Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (array[i] < array[j])
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        return array;
    }

    public static string[] Sort(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (String.Compare(array[i], array[j]) < 0)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        return array;
    }

    public static DateTime[] Sort(DateTime[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (DateTime.Compare(array[i], array[j]) < 0)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        return array;
    }
}
