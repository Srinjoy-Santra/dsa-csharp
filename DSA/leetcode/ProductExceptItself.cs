namespace DSA.leetcode;

// https://leetcode.com/problems/product-of-array-except-self/

public class ProductExceptSelf {
    
    // Compute product by shifting one element to right
    // Compute product back by shifting one element to the left
    public static int[] Solution(int[] nums) {
        int prod =1;
        int[] res = new int[nums.Length];
        for(int i=0;i<nums.Length;i++)
        {
            res[i] = prod;
            prod*=nums[i];
        }
        
        prod =1;
        for(int i=nums.Length-1;i>=0;i--)
        {
            res[i]*=prod;
            prod*=nums[i];
        }
        
        return res;
    }
}