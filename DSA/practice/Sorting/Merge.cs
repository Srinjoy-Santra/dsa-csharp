namespace DSA.practice.Sorting;

// https://www.youtube.com/watch?v=TzeBrDU-JaY

public class Merge
{
    private static int[] Sort(int[] arr)
    {
        if (arr.Length < 2)
            return arr;
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        Array.Copy(arr, left, mid);
        
        int[] right = new int[arr.Length - mid];
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        left = Sort(left);
        right = Sort(right);
        arr = DoMerge(left, right);
        return arr;
    }

    private static int[] DoMerge(int[] left, int[] right)
    {
        int leftIndex = 0, rightIndex = 0, newIndex = 0;
        int[] arr = new int[left.Length + right.Length];
        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] <= right[rightIndex])
                arr[newIndex] = left[leftIndex++];
            else
                arr[newIndex] = right[rightIndex++];
            newIndex++;
        }

        while (leftIndex < left.Length)
        {
            arr[newIndex++] = left[leftIndex++];
        }
        while (rightIndex < right.Length)
        {
            arr[newIndex++] = right[rightIndex++];
        }
        return arr;
    }
    
    public static void Run()
    {
        int[] arr = { 2, 1, 2, 3, 1, 2, 4 };
        int range = 5;
        int[] narr = Sort(arr);
        Console.WriteLine(string.Join(",", narr)); 
    }

}