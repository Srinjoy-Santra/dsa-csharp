namespace DSA.leetcode;

// https://leetcode.com/problems/two-sum/

public class TwoSum
{
    public static int[] Solution(int[] nums, int target) {
        
        var result = new int[2];
        var dict = new Dictionary<int,int>();
        for(int i=0; i<nums.Length; i++)
        {
            
            if(dict.ContainsKey(nums[i]))
            {
                if(dict[nums[i]] != i)
                {
                    result[0] = dict[nums[i]];
                    result[1] = i;
                    return result;
                }
            }
            if(!dict.ContainsKey(target - nums[i]))
                dict.Add(target - nums[i], i);
        }
        return result;
        
    }
}