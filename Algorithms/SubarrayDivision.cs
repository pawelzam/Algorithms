namespace Algorithms;
public static class SubarrayDivision
{
    public static int Apply(int[] arr, int targetSum, int subarrayLength)
    {
        int count = 0;
        int currentSum = 0;

        if (subarrayLength > arr.Length)
        {
            return 0;
        }

        for (int i = 0; i < subarrayLength; i++)
        {
            currentSum += arr[i];
        }

        if (currentSum == targetSum)
        {
            count++;
        }

        for (int i = subarrayLength; i < arr.Length; i++)
        {
            currentSum += arr[i] - arr[i - subarrayLength];
            
            if (currentSum == targetSum)
            {
                count++;
            }
        }

        return count;
    }
}
