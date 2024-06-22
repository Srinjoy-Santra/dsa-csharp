namespace DSA.leetcode;

public class MinimumWindowSubstring
{
    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(t)) return string.Empty;

        var countT = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();

        foreach (var c in t)
        {
            AddCharToDictionary(c, countT);
        }

        var have = 0;
        var need = countT.Count;
        var left = 0;
        var res = new[] { -1, -1 };
        var resultLength = int.MaxValue;
        for (var right = 0; right < s.Length; right++)
        {
            var c = s[right];
            AddCharToDictionary(c, window);

            if (countT.ContainsKey(c) && window[c] == countT[c]) have++;

            while (have == need)
            {
                // update our result
                var windowSize = right - left + 1;
                if (windowSize < resultLength)
                {
                    res = new[] { left, right };
                    resultLength = windowSize;
                }

                // pop from the left of our window
                window[s[left]]--;
                if (countT.ContainsKey(s[left]) && window[s[left]] < countT[s[left]])
                {
                    have--;
                }

                left++;
            }
        }

        return resultLength == int.MaxValue
            ? string.Empty
            : s.Substring(res[0], res[1] - res[0] + 1);
    }

    private void AddCharToDictionary(char c, IDictionary<char, int> dict)
    {
        if (dict.ContainsKey(c)) dict[c]++;
        else dict.Add(c, 1);
    }
    
    public string MinWindow2(string s, string t) {

        if (string.IsNullOrEmpty(t)) return "";

        Dictionary<char, int> countT = new();
        for(int i=0;i<t.Length; i++)
        {
            char c = t[i];
            countT[c] = countT.GetValueOrDefault(c, 0)+1;
        }
        
        Dictionary<char, int> window = new();
        int have = 0;
        int need = countT.Count;
        int minWstart = -1;
        int minWlen = int.MaxValue;
        int start = 0;
        for(int end = 0; end < s.Length; end++)
        {
            char c = s[end];
            if(countT.ContainsKey(c))
            {
                window[c] = window.GetValueOrDefault(c, 0)+1;
                if(window[c] == countT[c])
                    have++;
            }

            while (have == need)
            {
                if(end - start + 1 < minWlen)
                {
                    minWlen = end - start + 1;
                    minWstart = start;
                }
                char startc = s[start];
                if(window.ContainsKey(startc))
                {
                    window[startc]--;
                    if(countT.ContainsKey(startc) && window[startc] < countT[startc])
                      have--;
                }
                start++;
            }
        }  
        if(minWlen == int.MaxValue)
        {
            return "";
        }

        return s.Substring(minWstart, minWlen);
    }
}

