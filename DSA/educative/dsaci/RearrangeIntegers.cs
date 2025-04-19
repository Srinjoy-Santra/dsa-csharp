using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace DSA.educative.dsaci;
/*
 * Implement a function reArrange(int arr[], int size),
 * which takes an array arr and its size as input and
 * rearranges the elements such that all the negative elements appear on the left and positive elements appear on the right.
 */
public class RearrangeIntegers
{
    public void Solution(int[] arr)
    {
        int size =arr.Length, j = 0; 
        for (int i = 0; i < size; i++) { 
            if (arr[i] < 0) {   // if negative number found
                if (i != j) 
                    (arr[i], arr[j]) = (arr[j], arr[i]);  // swapping with leftmost positive 
                j++; // only increments if a negative value is found
            } 
        }
    }

    public static void Run()
    {
        RearrangeIntegers ri = new();
        int[] arr = [-23, 1, -2, 0, 44, -9, 8, 7];
        ri.Solution(arr);
        Console.WriteLine(string.Join(",",arr));
        arr = [ 14, -3, 56, 29, -39, -94, 87 ];
        ri.Solution(arr);
        Console.WriteLine(string.Join(",",arr));
    }
}