namespace Algorithms;
public static class Superdigit
{
    public static int superDigit(string n, int k)
    {
        return (int)superDigit(string.Join("", Enumerable.Range(0, k).Select(_ => n)));

    }

    private static int superDigit(string s)
    {
        do
        {

            s = s.Split().Aggregate((a, b) => a + b);
        } while (s.Length > 1);

        return Convert.ToInt32(s);

    }
}
