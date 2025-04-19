namespace DSA.leetcode;

public class MeetingRooms2
{
    public bool Solution(List<Interval> intervals)
    {
        intervals.Sort((a, b) => a.Start.CompareTo(b.Start));

        if (intervals.Count == 1)
            return true;
        List<Interval> dayIntervals = new();
        dayIntervals.Add(intervals[0]);
        for (int i = 1; i < intervals.Count; i++)
        {
            bool isAdded = false;
            for (int j = 0; j < dayIntervals.Count; j++)
            {
                if (dayIntervals[j].End >= intervals[i].Start || dayIntervals[j].Start <= intervals[i].End)
                {
                    dayIntervals.Add(intervals[i]);
                    isAdded = true;
                }
            }

            if (!isAdded)
            {
                dayIntervals.Add(intervals[i]);
            }
        }

        return true;
    }

    public static void Run()
    {
        var mr = new MeetingRooms();
        List<Interval> intervals = new (){
            new Interval(0, 40 ),
            new Interval(5, 10 ),
            new Interval(15, 20 ),
        };
        Console.WriteLine(mr.Solution(intervals));
        
        intervals = new (){
            new Interval(4, 9 )
        };
        Console.WriteLine(mr.Solution(intervals));
        
        intervals = new (){
            new Interval(0, 8 ),
            new Interval(8, 10 ),
        };
        Console.WriteLine(mr.Solution(intervals));
    }
}