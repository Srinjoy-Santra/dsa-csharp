namespace DSA.practice.Sorting;

public class Heap
{
    private class Greater : IComparer<int>
    {
        // highest to lowest
        public int Compare(int x, int y) => x - y;
    }

    private static void Sort(int[] arr)
    {
        var heap = new PriorityQueue<int, int>(new Greater());
        foreach(int element in arr)
        {
            heap.Enqueue(element, element);
        }
        for(int i=0; i< arr.Length;i++)
        {
            arr[i] =heap.Dequeue();
        }
    }


    public static void Run()
    {
        int[] arr = { -4, 1, 25, 50, 8, 10, 23  };
        int range = 5;
        Sort(arr);
        Console.WriteLine(string.Join(",", arr)); 
    }
}