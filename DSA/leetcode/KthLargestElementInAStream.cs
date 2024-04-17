namespace DSA.leetcode;

// https://leetcode.com/problems/kth-largest-element-in-a-stream/description/
public class KthLargestElementInAStream
{
    PriorityQueue<int, int> _pq;
    int _k;
    public KthLargestElementInAStream(int k, int[] nums) {
        _k=k;
        _pq=new(k);
        foreach(int num in nums){
            Add(num);
        }
    }
    
    public int Add(int val) {
        _pq.Enqueue(val, val);
        if(_pq.Count > _k) 
            _pq.Dequeue();
        
        return _pq.Peek();
    }
}