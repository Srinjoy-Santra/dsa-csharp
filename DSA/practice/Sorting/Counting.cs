namespace DSA.practice.Sorting;

/*
 * Resources :
 * https://www.youtube.com/watch?v=pEJiGC-ObQE
 * https://www.youtube.com/watch?v=1mh2vilbZMg
 */
public class Counting
{
    // stable?
    private static int[] MySort(int[] arr, int range)
    {
        var frequencies = new int[range+1];

        foreach (int i in arr)
        {
            frequencies[i]++;
        }

        int j = 0;
        for (int i=0; i<frequencies.GetLength(0); i++)
        {
            while (frequencies[i] > 0)
            {
                arr[j++] = i;
                frequencies[i]--;
            }
        }

        return arr;
    }
    
    internal static int[] Sort(int[] arr, int range)
    {
        var frequencies = new int[range+1];
        var narr = new int[arr.Length];

        foreach (int i in arr)
        {
            frequencies[i]++;
        }

        for (int i = 1; i < range+1; i++)
            frequencies[i] += frequencies[i - 1];

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            narr[--frequencies[arr[i]]] = arr[i];
            // place the last occurence of array element to the last position allowed by the frequency
            // maintains stability
        }

        return narr;
    }
    
    public static void Run()
    {
        int[] arr = { 2, 1, 2, 3, 1, 2, 4 };
        int range = 5;
        int[] narr = MySort(arr, range);
        Console.WriteLine(string.Join(",", narr)); 
        
        int[] arr1 = { 2, 1, 1, 0, 2, 5, 4, 0, 2, 8, 7, 7, 9, 2, 0, 1, 9 };
        range = 9;
        int[] narr1 = Sort(arr1, range);
        Console.WriteLine(string.Join(",", narr1)); 
    }
}