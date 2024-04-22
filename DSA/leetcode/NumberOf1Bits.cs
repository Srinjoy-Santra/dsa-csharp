namespace DSA.leetcode;

// https://leetcode.com/problems/number-of-1-bits/description/
public class NumberOf1Bits
{
    public int HammingWeight(int n)
    {
        int count = 0;
        while (n > 0)
        {
            // fast forwards to signed bit i.e 1
            n &= n - 1;
            count++;
        }

        return count;
    }
}