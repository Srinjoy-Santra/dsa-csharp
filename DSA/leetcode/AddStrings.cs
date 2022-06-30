using System.Text;

// https://leetcode.com/problems/add-strings/

namespace DSA.leetcode
{
    public class AddStrings
    {
        public static string Solution(string a, string b)
        {
            StringBuilder result = new StringBuilder();
            string first, second;
            if(a.Length > b.Length)
            {
                first = a; second = b;
            }else{
                first =b; second=a;
            }

            char carry = '0',sum;
            for(int i=0; i<first.Length; i++)
            {
                (sum, carry) = Sum(first, second, i, carry);
                result.Append(sum);
            }
            if(carry!='0')
            {
                result.Append(carry);
            }
            char[] k = result.ToString().ToCharArray();
            Array.Reverse(k);
            return new string(k);
        }

        private static (char,char) Sum(string first, string second, int i, char carry)
        {
            int r = first[first.Length - 1 -i]-'0';
            
            if(i < second.Length)
            {
                r+= second[second.Length - 1 -i]-'0';
                
            }
            if(carry!='0')
            {
                r+= carry - '0';
                
            }
            char sum = (char)('0' + r%10);
            carry = (char)('0' + r/10);
            return (sum, carry);
        }
    }
}