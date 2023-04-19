namespace DSA.leetcode;

// https://leetcode.com/problems/top-k-frequent-elements/submissions/
public class TopKFrequent
{
    public static int[] Solution(int[] nums, int k) {
        
        Dictionary<int,int> frequencies = new();
    
        foreach(int i in nums)
        {
            if(frequencies.ContainsKey(i))
                frequencies[i]++;
            else 
                frequencies[i]=1;
        }
    
        var bucket = new List<int>[nums.Length+1];
        foreach(var frequency in frequencies)
        {
            if(bucket[frequency.Value] == null)
                bucket[frequency.Value] = new List<int>();
            bucket[frequency.Value].Add(frequency.Key);
        }
    
        List<int> result = new();
    
        for(int i=nums.Length; result.Count<k;i--)
        {
            if(bucket[i] != null)
                result.AddRange(bucket[i]);
        }
    
        return result.ToArray();
    }
}

// Takeaway: Modified bucket sort