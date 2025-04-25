// ---
// problem: Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
// tags:
//   - array
//   - hash
//   - medium
//   - leetcode
// link: https://leetcode.com/problems/top-k-frequent-elements/
//
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
public class TopKFrequent
{
    public static int[] Solution(int[] nums, int k) {
        
        // calculating frequency of all nums
        Dictionary<int,int> frequencies = new();
    
        foreach(int i in nums)
        {
            if(frequencies.ContainsKey(i))
                frequencies[i]++;
            else 
                frequencies[i]=1;
        }
    
        // mapping computed frequency to the numbers
        var bucket = new List<int>[nums.Length+1];
        foreach(var frequency in frequencies)
        { 
            // null coalescing operator
            bucket[frequency.Value] ??= new List<int>();
            bucket[frequency.Value].Add(frequency.Key);
            
            // Alternative 
            // if(bucket[frequency.Value] == null) 
            //    bucket[frequency.Value] = new List<int>();
            //bucket[frequency.Value].Add(frequency.Key);
        }
    
        //Adding to top k result based on count
        List<int> result = new();
        // nums.Length is the highest frequency that can be, and decreases till we get k elements in result
        for(int i=nums.Length; result.Count<k;i--)
        {
            // null conditional operator
            bucket[i]?.ForEach(result.Add);
            
            //if(bucket[i] != null)
            // result.AddRange(bucket[i]);
        }
    
        return result.ToArray();
    }
}

// Takeaway: Modified bucket sort
