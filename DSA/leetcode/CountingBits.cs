namespace DSA.leetcode;

// https://leetcode.com/problems/counting-bits/description/
public class CountingBits
{
    public int[] Solution(int n)
    {
        var instance = new NumberOf1Bits();
        List<int> result = new();

        for (int i = 0; i <= n; i++)
        {
            result.Add(instance.HammingWeight(i));
        }

        return result.ToArray();
    }
}