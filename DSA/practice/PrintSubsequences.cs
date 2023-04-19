namespace DSA.practice;

// https://youtu.be/AxNNVECce8c?list=PLgUwDviBIf0rGlzIn_7rsaR2FQ5e6ZOL9
// Recursion on subsequences
// TC = O(2^n.n)
// SC = O(n)

public class PrintSubsequences
{
    private static void Print(int i, int[] arr, IList<int> list)
    {
        if (i == arr.Length)
        {
            Console.WriteLine(string.Join(",", list));
            return;
        }
        
        list.Add(arr[i]);
        Print(i+1, arr, list);
        
        list.RemoveAt(list.Count-1);
        Print(i+1, arr, list);
    }
    
    public static void Run()
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        List<int> list = new();
        Print(0, arr, list);
    }
}