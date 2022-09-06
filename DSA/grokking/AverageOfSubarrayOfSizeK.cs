
/*
Given an array, find the average of all contiguous subarrays of size ‘K’ in it.
*/
namespace DSA.grokking;

public class AverageOfSubarrayOfSizeK
{
    public static double[] Solution(int size, int[] arr)
    {
        int sum = 0;
        var result = new double[arr.Length-size+1];
        for (int end = 0; end < arr.Length; end++)
        {
            if (end >= size)
            {
                result[end - size] = (double) sum / size;
                sum -= arr[end - size];
            }
            sum += arr[end]; 
        }
        result[result.Length-1] = (double) sum / size;
        return result;
    }


}