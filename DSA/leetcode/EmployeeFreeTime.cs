namespace DSA.leetcode;

public class EmployeeFreeTime
{
    int[][] Solution(int[][][] schedule)
    {
        List<int[]> flattened = new();
        for (int i = 0; i < schedule.Length; i++)
        {
            flattened.AddRange(schedule[i]);
        }
        
        flattened.Sort((a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new();
        foreach (int[] interval in flattened)
        {
            if (merged.Count == 0 || merged[^1][1] < interval[0])
            {
                merged.Add(interval);
            }
            else
            {
                merged[^1][1] = Math.Max(merged[^1][1], interval[1]);
            }
        }

        List<int[]> freeTimes = new();
        for (var i = 1; i < merged.Count; i++)
        {
            int start = merged[i-1][1];
            int end = merged[i][0];
            freeTimes.Add([start,end]);
        }
        
        return freeTimes.ToArray();
    }

    public static void Run()
    {
        int[][][] schedule =
        [
            [
                [2, 4], [7, 10]
            ],
            [
                [1, 5], [6, 9]
            ]
        ];
        
        EmployeeFreeTime employeeFreeTime = new EmployeeFreeTime();
        int[][] freeTimes = employeeFreeTime.Solution(schedule);
        foreach (var interval in freeTimes)
        {
            Console.WriteLine($"{interval[0]},{interval[1]}");
        }
    }
}