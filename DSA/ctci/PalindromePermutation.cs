namespace DSA.ctci;

// https://leetcode.com/problems/palindrome-permutation/
public class PalindromePermutation
{
    public static bool Solution(string str)
    {
        Dictionary<char, int> d = new();
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (char.IsWhiteSpace(c))
            {
                continue;
            }
            if (char.IsUpper(c))
            {
                c = char.ToLower(c);
            }
            d[c] = d.GetValueOrDefault(c, 0) + 1;
        }

        int oddCount = 0;
        foreach(var p in d)
        {
            if (p.Value % 2 != 0)
            {
                oddCount++;
            }
        }

        return oddCount < 2;
    }

    public static void Main()
    {
        Console.WriteLine(Solution("Tact Coa"));
        Console.WriteLine(Solution("Tact Coba"));
    }
}