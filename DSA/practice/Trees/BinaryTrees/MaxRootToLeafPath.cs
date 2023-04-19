namespace DSA.practice.Trees.BinaryTrees;

public class MaxRootToLeafPath
{
    private static int Solution(Node? root)
    {
        if (root == null) return 0;

        int leftSum = Solution(root.Left);
        int rightSum = Solution(root.Right);

        return root.Value + Math.Max(leftSum, rightSum);
    }

    public static void Run()
    {
        Node root = new Node(5);
        root.Left = new Node(11);
        root.Right = new Node(3);
        root.Left.Left = new Node(4);
        root.Left.Right = new Node(2);
        root.Right.Right = new Node(1);
        
        Console.WriteLine(Solution(root));
    }
}