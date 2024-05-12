namespace DSA.leetcode;

public class ContainerWithMostWater
{
    public int MaxArea(int[] heights)
    {
        int left = 0, right = heights.Length-1, area=0;
        while(left < right)
        {
            // get minimum height among two
            int height = Math.Min(heights[left], heights[right]);
            // check area is more than the current max
            area = Math.Max(area, (right - left)*height);
            
            if(heights[left] > heights[right])
                right--;
            else left++;
        }
        return area;
    }
}