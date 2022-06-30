namespace DSA.grokking;

/*
 * Given an array of positive numbers and a positive number ‘S’,
    find the length of the smallest contiguous subarray whose sum is greater than or equal to ‘S’. 
    Return 0, if no such subarray exists.
 */
public class MinSizeSubArraySum
{

    public static int Solution(int[] arr, int S)
    {
       for(int size=1;size<S;size++)
       {
           int start=0,sum=0;
           for(int end=0;end<arr.Length;end++)
           {
               sum+=arr[end];
                if(end>=size-1)
                {
                    if(sum>=S)
                        return size;
                    start++;
                }
           }
       }

       return 0;
    }

}

