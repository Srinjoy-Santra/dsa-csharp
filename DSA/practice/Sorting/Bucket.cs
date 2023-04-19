namespace DSA.practice.Sorting;

public class Bucket
{
    private static int[] Sort(int[] arr)
    {
        int max = arr.Max();
        //for(int place =1; max/place > 0; place*=10)
           //arr = CountingSort.Sort(arr,)
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