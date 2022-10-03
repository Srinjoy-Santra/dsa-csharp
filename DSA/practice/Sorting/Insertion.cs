namespace DSA.practice.Sorting;

public class Insertion
{
    private static int[] Sort(int[] arr)
    {
        // loop for going through each index
        for (int i = 1; i < arr.Length; i++)
        {
            int val = arr[i];
            int j = i - 1;
            // loop to find the index where the current element can be placed and move rest
            for (; j >= 0 && arr[j] > val; j--)
                arr[j + 1] = arr[j];
            arr[j + 1] = val;
            Console.WriteLine(string.Join(",", arr));
        }

        return arr;
    }
    
    public static void Run()
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        int[] narr = Sort(arr);
        Console.WriteLine(string.Join(",", narr)); 
    }
}