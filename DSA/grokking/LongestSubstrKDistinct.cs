namespace DSA.grokking;

// Premium https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters/description/
public class LongestSubstrKDistinct
{
    public int Solution(string str, int k)
    {
        int maxDistinctCount = 0,
            start = 0;
        if (str.Length <= 1) return str.Length;
        
        var dict = new Dictionary<char,int>();
        dict.Add(str[start], 1);
        
        for (int end = 1; end < str.Length; end++)
        {
            dict[str[end]] = dict.GetValueOrDefault(str[end], 0)+1;
            if (dict.Count > k)
            {
                maxDistinctCount = Math.Max(maxDistinctCount, end-start);
                dict[str[start]] = dict.GetValueOrDefault(str[start], 0)-1;
                if (dict[str[start]] == 0)
                {
                    dict.Remove(str[start]);
                }
                start++;
            }
        }

        return maxDistinctCount;
    }

    public static void Run()
    {
        var instance = new LongestSubstrKDistinct();

        Console.WriteLine(instance.Solution("araaci", 2));
        Console.WriteLine(instance.Solution("araaci", 1));
        Console.WriteLine(instance.Solution("cbbebi", 3));
    }
}