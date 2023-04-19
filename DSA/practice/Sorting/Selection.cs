namespace DSA.practice.Sorting;

public class Selection
{
    private static int[] Sort(int[] arr)
    {
        // loop for going through each index
        for (int i = 0; i < arr.Length-1; i++)
        {
            int idx=i;
            // loop to find the index of max or min element
            for (int j = i+1; j < arr.Length-1; j++)
                if (arr[j] < arr[idx])
                    idx = j;

            (arr[i], arr[idx]) = (arr[idx], arr[i]); 
            Console.WriteLine(string.Join(",", arr)); 

        }

        return arr;
    }
    
    public static void Run()
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        int[] narr = Sort(arr);
        Console.WriteLine(string.Join(",", narr)); 
    }
}