using DSA.practice.Trees.BinaryTrees;

namespace DSA.leetcode;

public class KthSmallestElelmentInBST
{
    public int Solution(Node root, int k)
    {
        Stack<Node> stack = new();
        Node curr = root;

    while (stack.Count > 0 || curr != null)
        {
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.Left;
            }

            curr = stack.Pop();
            k--;
            if (k == 0)
            {
                return curr.Value;
            }

            curr = curr.Right;
            
        }

        return -1;
    }

    public static void Run()
    {
        Node root = new Node(3);
        root.Left = new Node(1);
        root.Left.Right = new Node(2);
        root.Right = new Node(4);

        KthSmallestElelmentInBST kse = new();
        Console.WriteLine("Example 1: "+kse.Solution(root, 1));

        root = new Node(5);
        root.Left = new Node(3);
        root.Left.Left = new Node(2);
        root.Left.Left.Left = new Node(1);
        root.Left.Right = new Node(4);
        root.Right = new Node(6);
        
        Console.WriteLine("Example 2: "+kse.Solution(root, 3));

    }
}