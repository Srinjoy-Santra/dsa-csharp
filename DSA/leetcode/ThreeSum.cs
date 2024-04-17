namespace DSA.leetcode;

// https://leetcode.com/problems/3sum/

public class ThreeSum
{
    
    public static IList<IList<int>> Solution(int[] nums) {
        Array.Sort(nums);
        
        var result = new List<IList<int>>();
        
        for(int i=0;i<nums.Length-2;i++)
        {
            if(i>0 && nums[i] == nums[i-1])
                continue;
            
            int left=i+1, right = nums.Length-1;
            
            while(left<right)
            {
                int sum = nums[i]+nums[left]+nums[right];
                if(sum>0) right--;
                else if(sum<0) left++;
                else
                {
                    result.Add(new List<int>{nums[i],nums[left],nums[right]});
                    left++;
                    
                    // it skips duplicate elements; faster 
                    while(nums[left] == nums[left-1] && left < right)
                        left++;
                }
            }     
        }

        return result;
    }
}