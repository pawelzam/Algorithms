namespace Algorithms;
public static class BinarySearch
{
    public static int Search(int[] array, int search)
    {
        var min = 0;
        var max = array.Length;
        
        
        while(min < max)
        {
            int middle = (min + max) / 2;
            if (array[middle] == search)
            {
                return middle;
            }

            if (array[middle] < search)
            {
                min++;
            }
            else
            {
                min = middle + 1;
            }
        }

        return -1;
    }
}
