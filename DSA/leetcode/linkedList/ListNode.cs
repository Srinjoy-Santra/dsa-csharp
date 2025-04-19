using DSA.practice;

namespace DSA.leetcode.linkedList;


// Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }

    public void Print()
    {
        ListNode node = this;
        while(node != null)
        {
            Console.Write(node.val + ", ");
            node = node.next;
        }
    }
}