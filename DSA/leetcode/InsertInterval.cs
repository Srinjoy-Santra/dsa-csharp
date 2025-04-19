namespace DSA.leetcode;

// https://leetcode.com/problems/insert-interval/description/
public class InsertInterval {
    public int[][] Insert(int[][] intervals, int[] newInterval) {

        var modifiedIntervals = new List<int[]>();

        for(int i=0;i<intervals.Length;i++){
            int[] currInterval = intervals[i];
            
            // if new interval precedes current interval, add new interval and all remaining intervals and return
            if(currInterval[0] > newInterval[1])
            {
                modifiedIntervals.Add(newInterval);
                modifiedIntervals.AddRange(intervals[i..]);
                return modifiedIntervals.ToArray();
            }

            // if new interval follows current interval, add current interval
            if (currInterval[1] < newInterval[0])
            {
                modifiedIntervals.Add(currInterval);
            }
            // if there is overlap of current and new intervals, merge
            else
            {
                int newStart = Math.Min(newInterval[0], currInterval[0]);
                int newEnd = Math.Max(newInterval[1], currInterval[1]);
                newInterval = [newStart, newEnd];
            }
        }

        modifiedIntervals.Add(newInterval);
        return modifiedIntervals.ToArray();
    }
}