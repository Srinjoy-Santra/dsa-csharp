using DSA.practice;

namespace DSA.leetcode;

public class MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        List<int[]> mergedIntervals = new();

        if (intervals.Length < 2)
            return intervals;

        Array.Sort(intervals, (first, second) => first[0].CompareTo(second[0]));
        Print(intervals);

        mergedIntervals.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] >= mergedIntervals[^1][0] && intervals[i][1] <= mergedIntervals[^1][1])
            {
                ;
            }
            else if (intervals[i][0] <= intervals[i - 1][1])
            {
                mergedIntervals[^1][1] = Math.Max(intervals[i][1], intervals[i - 1][1]);
            }
            else mergedIntervals.Add(intervals[i]);
        }

        return mergedIntervals.ToArray();
    }

    public static void Print(int[][] intervals)
    {
        foreach (var t in intervals)
        {
            Console.Write("[");
            foreach (var t1 in t)
            {
                Console.Write(t1 + ",");
            }
            Console.WriteLine("],");
        }
    }

    public static void Run()
    {
        MergeIntervals mi = new();
        int[][] intervals = { [1, 10], [2, 3], [4, 5], [6, 7], [8, 9] };
        //Console.WriteLine(string.Join(",", mi.Merge(intervals).ToList()));
        
        
        intervals = new int[][]{[2,3],[5,5],[2,2],[3,4],[3,4]};
        Print(mi.Merge(intervals));
        //Console.WriteLine(string.Join(",", string.Join(":", mi.Merge(intervals).ToList())));
    }
}