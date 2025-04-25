// ---
// tags:
// - linkedlist
// - easy
// - leetcode
// link: https://leetcode.com/problems/reorder-list/description/
// jupyter:
//   jupytext:
//     cell_metadata_filter: -all
//     formats: md,cs:light
//     text_representation:
//       extension: .cs
//       format_name: light
//       format_version: '1.5'
//       jupytext_version: 1.16.7
// ---

// +
using DSA.leetcode.linkedList;
namespace DSA.leetcode;

public class ReorderList
{
    public static void Solution(ListNode head)
    {
        // slow and fast pointers
        ListNode slow = head, fast = head.next;
        // no need to check for slow null or not
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // reverse second half
        ListNode nHead = slow, prev = null;
        while(true)
        {
            ListNode next = nHead.next;
            nHead.next = prev;
            prev = nHead;
            if (next == null)
            {
                break;
            }
            nHead = next;
        }

        // first traverses first half of linked list, 
        // second traverses second half of linked list
        // first's next is second, second's next is first's next
        ListNode first = head, second = nHead;
        while(first!=null && second != null)
        {
            ListNode fn = first.next, sn = second.next;
            first.next = second;
            second.next = fn;

            first = fn;
            second = sn;
        }
    }

    public static void Run()
    {
        ListNode head1 = new ListNode(1);
        head1.next = new ListNode(2);
        head1.next.next = new ListNode(3);
        head1.next.next.next = new ListNode(4);

        Solution(head1);
        head1.Print();
    }
}
