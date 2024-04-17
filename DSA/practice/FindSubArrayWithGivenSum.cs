namespace DSA.practice;

// https://www.geeksforgeeks.org/find-subarray-with-given-sum-in-array-of-integers/
// Dynamic programming



public class FindSubArrayWithGivenSum
{
    private static (int,int) SubArraySum(int[] arr, int sum)
    {
        int currentSum = 0, start = 0, end = -1;

        Dictionary<int, int> dictionary = new();

        for (int i = 0; i < arr.Length - 1; i++)
        {
            currentSum += arr[i];

            if (currentSum == sum)
            {
                start = 0;
                end = i;
                break;
            }

            if (dictionary.ContainsKey(currentSum - sum))
            {
                start = dictionary[currentSum - sum] + 1;
                end = i;
                break;
            }

            dictionary[currentSum] = i;
            dictionary.Select(p => $"{p.Key}: {p.Value},").ToList().ForEach(Console.Write);
            Console.WriteLine();
        }

        return (start, end);
    }
    
    public static void Run()
    {
        int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
        int sum = 23;
        (int start, int end)  = SubArraySum(arr, sum);
        Console.WriteLine($"{start},{end}");
        
        int[] arr2 = { 10, 2, -2, -20, 10 };
        sum = -10;
        (start, end)  = SubArraySum(arr2, sum);
        Console.WriteLine($"{start},{end}");
    }
}