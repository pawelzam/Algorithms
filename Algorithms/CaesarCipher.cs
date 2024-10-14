using System.Collections;
using System.Text;

namespace Algorithms;
public static class CaesarCipher
{
    private static string alphabet = "abcdefghijklmnopqrstuvwxyz";
    public static string Encode(string s, int k)
    {
        if(k > alphabet.Length)
        {
            while (k >= alphabet.Length)
            {
                k -= alphabet.Length;
            }
        }

        var result = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (!alphabet.Contains(c, StringComparison.OrdinalIgnoreCase))
            {
                result.Append(c);
                continue;
            }

            var originalIndex = alphabet.IndexOf(c, StringComparison.OrdinalIgnoreCase);
            var index = originalIndex + k;
            if (index > alphabet.Length - 1)
            {
                index = k - (alphabet.Length - originalIndex);
            }

            result.Append(Char.IsUpper(c) ? alphabet.ToUpper()[index] : alphabet[index]);
        }

        return result.ToString();
    }
}
