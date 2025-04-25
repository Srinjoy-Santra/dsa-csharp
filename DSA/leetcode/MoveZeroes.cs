namespace DSA.leetcode;

public class MoveZeroes
{
    public static void Solution(int[] nums)
    {
        // p points to the position where next non-zero position should be
        for (int i = 0, p = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[p]) = (nums[p], nums[i]);
                p++;
            }
        }
    }

    public static void Run()
    {
        int[] nums = new int[] { 2, 0, 4, 0, 9 };
        Solution(nums);
        Console.WriteLine(string.Join(",", nums));
    }
}