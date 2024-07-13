namespace DSA.practice.String;

// https://en.wikipedia.org/wiki/Knuth%E2%80%93Morris%E2%80%93Pratt_algorithm

public class KnuthMorrisPratt
{
    public bool Search(string text, string pattern)
    {
        int[] pi = CreateLongestPrefixSuffix(pattern);
        return true;
    }

    private int[] CreateLongestPrefixSuffix(string pattern)
    {
        // The default values of numeric array elements are set to zero, and reference elements are set to null.
        var pi = new int[pattern.Length];
        
        
        

        return pi;
    }
}