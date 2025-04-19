namespace DSA.leetcode;

// Premium https://neetcode.io/problems/meeting-schedule
public record Interval(int Start, int End);

public class MeetingRooms
{
    public bool Solution(List<Interval> intervals)
    {
        intervals.Sort((a, b) => a.End.CompareTo(b.Start));

        if (intervals.Count == 1)
            return true;
        for (int i = 1; i < intervals.Count; i++)
        {
            var a = intervals[i - 1];
            var b = intervals[i];
            if (a.End > b.Start)
            {
                return false;
            }
        }

        return true;
    }

    public static void Run()
    {
        var mr = new MeetingRooms();
        List<Interval> intervals = new (){
            new Interval(0, 30 ),
            new Interval(5, 10 ),
            new Interval(15, 20 ),
        };
        Console.WriteLine(mr.Solution(intervals));
        intervals = new (){
            new Interval(5, 8 ),
            new Interval(9, 15 ),
        };
        Console.WriteLine(mr.Solution(intervals));
        intervals = new (){
            new Interval(0, 8 ),
            new Interval(8, 10 ),
        };
        Console.WriteLine(mr.Solution(intervals));
    }
}