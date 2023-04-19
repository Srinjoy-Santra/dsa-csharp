namespace DSA.practice.Sorting;

public class Bubble
{
    private static int[] Sort(int[] arr)
    {
        // loop for going through each index
        for (int i = 0; i < arr.Length-1; i++)
        {
            // loop to swap at each index
            for (int j = 0; j < arr.Length-1-i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    //Console.WriteLine(string.Join(",", arr)); 
                }
            }
        }

        return arr;
    }
    
    public static void Run()
    {
        int[] arr = { 2, 1, 2, 3, 1, 2, 4 };
        int[] narr = Sort(arr);
        Console.WriteLine(string.Join(",", narr)); 
    }
}