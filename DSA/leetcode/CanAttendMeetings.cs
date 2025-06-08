namespace DSA.leetcode;

public class CanAttendMeetings
{
    public bool Solution(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
        for (int i=1;i<intervals.Length;i++)
        {
            if (intervals[i][0] < intervals[i - 1][1])
            {
                return false;
            }
        }
        return true;
    }

    public static void Run()
    {
        CanAttendMeetings cam = new();

        int[][] intervals = [[2,4],[9,12],[6,9], [13,15]];
        Console.WriteLine(cam.Solution(intervals));
        
        intervals = [[10,12],[6,9],[13,15]];
        Console.WriteLine(cam.Solution(intervals));

    }
}