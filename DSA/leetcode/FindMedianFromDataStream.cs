namespace DSA.leetcode;

// https://leetcode.com/problems/find-median-from-data-stream/description/
public class FindMedianFromDataStream
{
    
    // left : max heap to contain values smaller than median
    // right : min heap to contain values larger than median
    PriorityQueue<int, int> left, right;

    
    public FindMedianFromDataStream() {
        // left : max heap; comparer created from lambda https://stackoverflow.com/questions/63081723/cant-use-lambda-as-icomparer
        left = new(Comparer<int>.Create((x,y) => y-x));
        // min : min heap (default)
        right = new();
    }
    
    public void AddNum(int num) {
        left.Enqueue(num, num);

        // every number in left heap <= every number in right heap
        if(left.Count > 0 && right.Count > 0 && left.Peek() > right.Peek())
        {
            int val = left.Dequeue();
            right.Enqueue(val, val);
        }

        // uneven size
        if(left.Count - right.Count > 1)
        {
            int val = left.Dequeue();
            right.Enqueue(val, val);
        }
        if(right.Count - left.Count > 1)
        {
            int val = right.Dequeue();
            left.Enqueue(val, val);
        } 
    }
    
    public double FindMedian() {
        if(left.Count > right.Count)
        {
            return left.Peek();
        }

        if(left.Count < right.Count)
        {
            return right.Peek();
        }

        return (left.Peek() + right.Peek()) / (double) 2;

    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */