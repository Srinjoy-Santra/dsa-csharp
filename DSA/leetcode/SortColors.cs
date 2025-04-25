namespace DSA.leetcode;

// related to quicksort partition

public class SortColors
{
    public static void Solution(int[] nums)
    {
        int left = 0, // separates 0s and 1s
            right = nums.Length-1; // separates 1s and 2s

        for (int i = 0; i < nums.Length && i <= right;)
        {
            if (nums[i] == 0)
            {
                (nums[i], nums[left]) = (nums[left], nums[i]);
                left++;
                i++;
            }
            else if (nums[i] == 2)
            {
                (nums[i], nums[right]) = (nums[right], nums[i]);
                right--;
            }
            else i++;
        }
        
        
    }

    public static void Run()
    {
        int[] nums = [2, 0, 2, 1, 1, 0];
        Solution(nums);
        Console.WriteLine(string.Join(",", nums));
    }
}