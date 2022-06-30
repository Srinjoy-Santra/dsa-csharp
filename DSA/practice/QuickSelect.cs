namespace DSA.practice;

/*
 * Similar question: https://leetcode.com/problems/kth-largest-element-in-an-array/
 * Resources :
 * https://www.youtube.com/watch?v=XEmy13g1Qxc (Neetcode)
 * https://www.geeksforgeeks.org/quickselect-algorithm/ 
 */
public class QuickSelect
{
    private int CreatePartition(int[] arr, int low, int high)
    {
        int pivot = arr[high], pivotIndex = low,temp;

        for (int i = low; i <= high; i++)
        {
            if (arr[i] < pivot)
            {
                temp = arr[i];
                arr[i] = arr[pivotIndex];
                arr[pivotIndex] = temp;
                pivotIndex++;
            }
        }

        temp = arr[pivotIndex];
        arr[pivotIndex] = arr[high];
        arr[high] = temp;

        return pivotIndex;
    }

    private int KthSmallest(int[] arr, int k, int low, int high)
    {
        int partition = CreatePartition(arr, low, high);
        if (partition == k)
        {
            return arr[k];
        }
        else if (partition > k)
        {
            return KthSmallest(arr, k, low, partition - 1);
        }
        else return KthSmallest(arr, k, partition + 1, low);
    }
    
    public static void Run()
    {
        int[] array = { 10, 4, 5, 8, 6, 11, 26 };
        QuickSelect qs = new();
        int k = 3;
        Console.WriteLine(qs.KthSmallest(array,k-1, 0, array.Length-1));
    }
}