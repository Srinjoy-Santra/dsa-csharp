namespace DSA.practice.String;

// https://en.wikipedia.org/wiki/Knuth%E2%80%93Morris%E2%80%93Pratt_algorithm

public class KnuthMorrisPratt
{
    public bool Search(string text, string pattern)
    {
        int[] lps = ComputeLPS(pattern);

        int i = 0, j=0;
        bool result = false;
        while (text.Length - i > pattern.Length - j)
        {
            if (pattern[j] == text[i])
            {
                j++;
                i++;
            }

            if (j == pattern.Length)
            {
                result = true;
                j = lps[j - 1];
            }
            else if (i < text.Length && pattern[j] != text[i])
            {
                if (j == 0)
                    i++;
                else j = lps[j - 1];
            }
        }
        
        return result;
    }

    // TC = O(n)
    // SC = O(n)
    private int[] CreateLongestPrefixSuffix(string pattern)
    {
        // The default values of numeric array elements are set to zero, and reference elements are set to null.
        var pi = new int[pattern.Length];
        Dictionary<char, int> positions = new();
        
        for(int i= 0; i<pattern.Length; i++)
        {
            if(positions.TryGetValue(pattern[i], out int v))
            {
                pi[i] = v + 1;
            } 
            else
            {
                positions[pattern[i]] = i;
            }
        }

        return pi;
    }
    
    private int[] ComputeLPS(string pattern)
    {
        int len = 0, i = 1;
        int[] lps = new int[pattern.Length];
        lps[0] = 0;
        while (i < pattern.Length)
        {
            if (pattern[i] == pattern[len])
            {
                len++;
                lps[i] = len;
                i++;
            }
            else
            {
                if (len == 0)
                {
                    lps[i] = len;
                    i++;
                }
                else len = lps[len - 1]; // why???
            }
        }

        return lps;
    }

    public static void Run()
    {
        KnuthMorrisPratt kmp = new();
        Console.WriteLine(kmp.Search("aaaaanaaana", "aaaa"));
        
        
        int[] pi = kmp.CreateLongestPrefixSuffix("ababd");
        Console.WriteLine(string.Join(",", pi));
        
        pi = kmp.ComputeLPS("ababd");
        Console.WriteLine(string.Join(",", pi));
    }
}