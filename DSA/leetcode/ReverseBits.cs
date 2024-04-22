namespace DSA.leetcode;

public class ReverseBits
{
    public uint Solution(uint n)
    {
        uint res=0;
        for (int i = 0; i < 32; i++)
        {
            // extracting last bit
            uint bit = (n >> i) & 1;
            // last bit being shifted to its reversed position
            res |= bit << (31 - i);
        }

        return res;
    }
}