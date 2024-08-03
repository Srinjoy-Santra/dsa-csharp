/*
---
problem: Given two binary strings a and b, return their sum as a binary string.
tags:
  - bit-manipulation
  - easy
  - leetcode
link: https://leetcode.com/problems/add-binary/
---
*/

using System.Text;

namespace DSA.leetcode
{
    public class AddBinary
    {
        public static string Solution(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int i = a.Length - 1, j = b.Length - 1;
            int carry = 0;
            while (i >= 0 || j >= 0)
            {
                Console.WriteLine((i,j,carry));
                int sum = carry;
                if (i >= 0) sum += a[i--] - '0';
                if (j >= 0) sum += b[j--] - '0';
                sb.Append(sum % 2);
                carry = sum / 2;
            }
            if (carry > 0) sb.Append(carry);
            char[] k = sb.ToString().ToCharArray();
            Array.Reverse(k);
            return new string(k);
        }
    }
}