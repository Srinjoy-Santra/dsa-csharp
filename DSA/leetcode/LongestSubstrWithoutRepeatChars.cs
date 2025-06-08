// -*- coding: utf-8 -*-
// ---
// jupyter:
//   jupytext:
//     cell_metadata_filter: -all
//     formats: md,cs:light
//     text_representation:
//       extension: .cs
//       format_name: light
//       format_version: '1.5'
//       jupytext_version: 1.16.7
// ---


namespace DSA.leetcode;

public class LongestSubstrWithoutRepeatChars
{
    public int Solution(string s)
    {
        int left = 0;
        HashSet<char> set = new HashSet<char>();
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }

    public static void Run()
    {
        LongestSubstrWithoutRepeatChars ls = new();
        Console.WriteLine(ls.Solution("abcabcbb"));
        Console.WriteLine(ls.Solution("bbbbb"));
        Console.WriteLine(ls.Solution("pwwkew"));
    }
}
