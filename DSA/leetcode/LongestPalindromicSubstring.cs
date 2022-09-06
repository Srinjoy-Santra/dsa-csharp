namespace DSA.leetcode;

public class LongestPalindromicSubstring
{
    private static int low=0, maxLen=0;
    
    public static string Solution(string s) {
        if(s.Length < 2) return s;

        for(int i=0;i<s.Length-1;i++)
        {
            IsLongerPalindrome(i, i+1, s);
            IsLongerPalindrome(i, i, s);
            Console.WriteLine(low +", "+ maxLen);
        }
        
        return s.Substring(low, maxLen);
    }
    
    public static void IsLongerPalindrome(int l, int r, string s)
    {
        while(l>=0 && r<s.Length && s[l] == s[r])
        {
            l--;
            r++;
            Console.WriteLine(l +", "+ r);
        }
        if(r-l-1>maxLen)
        {
            low = l+1;
            maxLen = r-l-1;
        }
    }
}