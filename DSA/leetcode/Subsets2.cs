namespace DSA.leetcode;

// https://leetcode.com/problems/subsets-ii/submissions/
// TC = O((2^n)*n)
// SC = O((2^n)*n) ?

public class Subsets2
{
    public static IList<IList<int>> Solution(int[] nums) {
        Array.Sort(nums);
        var currentSet = new List<int>();
        var subsets = new List<List<int>>();
        FindSubsets(nums, 0, currentSet, subsets);
        return new List<IList<int>>(subsets);
    }
    
    private static void FindSubsets(int[] nums, int index, IList<int> currentSet, IList<List<int>> subsets)
    {
        subsets.Add(new List<int>(currentSet));
        for(int i=index; i<nums.Length;i++)
        {
            if(i>index && nums[i] == nums[i-1])
                continue;
            currentSet.Add(nums[i]);
            FindSubsets(nums, i+1, currentSet, subsets);
            currentSet.RemoveAt(currentSet.Count-1);
        }
    }

}