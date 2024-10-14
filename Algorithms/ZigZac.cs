namespace Algorithms;
public static class ZigZac
{
    public static int[] FindZigZagSequence(int[] a)
    {
        Array.Sort(a);
        var res = new int[a.Length];
        res[a.Length / 2] = a.Max();
        for (var j = 0; j < (a.Length - 1) / 2; j++)
        {
            res[j] = a[j];
            res[a.Length / 2 + 1 + j] = a[a.Length - 2 - j];
        }

        return res;
    }
}
