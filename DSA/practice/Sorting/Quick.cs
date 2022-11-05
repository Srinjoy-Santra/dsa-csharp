namespace DSA.practice.Sorting;

// https://www.youtube.com/watch?v=COk73cpQbFQ  

public class Quick
{
    private static void Sort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int partitionIndex = Partition(arr, start, end);
            Sort(arr, start, partitionIndex - 1);
            Sort(arr, partitionIndex + 1, end);
        }
    }

    private static int Partition(int[] arr, int start, int end)
    {
        int pivot = arr[end];
        int partitionIndex = start;

        for (int i = start; i <= end; i++)
        {
            if (arr[i] < pivot)
            {
                (arr[i], arr[partitionIndex]) = (arr[partitionIndex], arr[i]);
                partitionIndex++;
            }
        }
        
        (arr[partitionIndex], arr[end]) = (arr[end], arr[partitionIndex]);

        return partitionIndex;
    }
    
    public static void Run()
    {
        //int[] arr = { 27,10,36,18,25,45 };
        int[] arr = { -4, 1, 25, 50, 8, 10, 23  };
        int range = 5;
        Sort(arr, 0 ,arr.Length-1);
        Console.WriteLine(string.Join(",", arr)); 
    }
}