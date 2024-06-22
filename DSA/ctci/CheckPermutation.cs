namespace DSA.ctci;

public class CheckPermutation
{
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        Dictionary<char, int> d = new();
        for(int i=0;i<s.Length;i++)
        {
            d[s[i]] = d.GetValueOrDefault(s[i], 0) + 1;
            d[t[i]] = d.GetValueOrDefault(t[i], 0) - 1;
        }

        foreach(var p in d)
        {
            if(p.Value != 0)
                return false; 
        }

        return true;
    } 
}
