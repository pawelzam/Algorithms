namespace Algorithms;
public static class PermutingTwoArrays
{

    public static string Permute(int k, int[] A, int[] B)
    {
        Array.Sort(A);
        Array.Sort(B);
        Array.Reverse(B);

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] + B[i] < k)
            {
                return "NO";
            }
        }

        return "YES";
    }

    private static bool Check(int k, List<int> A, List<int> B)
    {
        for (var i = 0; i < A.Count; i++)
        {
            if (A[i] + B[i] >= k)
            {
                return true;
            }

        }

        return false;
    }

    private static void Swap(List<int> arr, int i, int j)
    {
        var temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    private static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
