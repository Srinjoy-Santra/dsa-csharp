﻿using System.Text;
namespace DSA;

public class Class1
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