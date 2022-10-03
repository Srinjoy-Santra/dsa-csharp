namespace DSA.leetcode;

// https://leetcode.com/problems/maximum-product-subarray/submissions/

public class MaxProdArray
{
    public static int Solution(int[] nums) {
        int maxProd = 1, minProd=1, res = nums.Max();
        foreach(int num in nums)
        {
            if(num == 0)
            {
                (maxProd, minProd) = (1,1);
            }
            else 
            {
                int t = maxProd*num;
                maxProd = Math.Max(maxProd*num, Math.Max(minProd*num, num));
                minProd = Math.Min(t, Math.Min(minProd*num, num));
                res = Math.Max(maxProd, res);
            }
        }
        return res;
    }
}