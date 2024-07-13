namespace DSA.leetcode;

public class IndexOfFirstOccurenceInString
{
    // https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/
    
    public int StrStrRK(string haystack, string needle) {
        double patternHash = CreateRollingHash(needle);
        double textHash = 0;
        for (int i = 0; i < haystack.Length; i++)
        {
            textHash = textHash*10 + haystack[i];
            if (i >= needle.Length - 1)
            {
                if (textHash == patternHash)
                {
                    return i+1 - needle.Length;
                }
                textHash -= haystack[i+1 - needle.Length]*Math.Pow(10, needle.Length-1);
            }
        }
        return -1; 
    }

    private double CreateRollingHash(string pattern)
    {
        double hash = 0;
        for (int i = 0; i < pattern.Length; i++)
        {
            hash = hash * 10 + pattern[i];
        }

        return hash;
    }
}