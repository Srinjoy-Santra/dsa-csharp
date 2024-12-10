namespace DSA.practice.Trees.BinaryTrees;

public class BinarySearchTree
{
    public Node? Create(int[] values)
    {
        Node? root = null;
        foreach (int value in values)
        {
            root = Insert(root, value);
        }

        return root;
    }

    public Node? Insert(Node? root, int value)
    {
        if (root == null)
        {
            root = new Node(value);
        }
        else if (value < root.Value)
        {
            root.Left = Insert(root.Left, value);
        }
        else
        {
            root.Right = Insert(root.Right, value);
        }

        return root;
    }
    
    public bool Search(Node? root, int target)
    {
        if (root == null)
            return false;

        if (root.Value == target)
            return true;

        if (target < root.Value)
            return Search(root.Left, target);

        return Search(root.Right, target);

    }

    public Node? Delete(Node? root, int target)
    {
        if (root == null)
            return root;
        
        if (target < root.Value)
            return Delete(root.Left, target);

        if (target > root.Value)
            return Delete(root.Right, target);
        
        // no children
        if (root.Left == null && root.Right == null)
            return null;

        // one child
        if (root.Right != null)
            return root.Right;
        if (root.Left != null)
            return root.Left;

        // two children
        Node replacement = FindMaxNode(root.Left); // can also be done with min node of right
        root.Value = replacement.Value;
        _ = Delete(root.Left, replacement.Value);

        return root;
    }

    public Node FindMaxNode(Node root)
    {
        if (root.Right == null)
            return root;
        return FindMaxNode(root.Right);
    }
    
    public void BreadthFirstTraversal(Node? root)
    {
        if (root == null)
            return;
        BreadthFirstTraversal(root.Left);
        Console.Write(root.Value + " ,");
        BreadthFirstTraversal(root.Right);

    }

    public int MaxDepth(Node? root)
    {
        if (root == null)
            return 0;
        return 1 + Math.Max(MaxDepth(root.Left), MaxDepth(root.Right));
    }
    
    public int NodeCount(Node? root)
    {
        if (root == null)
            return 0;
        return 1 + NodeCount(root.Left) + NodeCount(root.Right);
    }
    
    public int InternalNodeCount(Node? root)
    {
        if (root == null)
            return 0;
        if (root.Left == null && root.Right== null)
            return 0;
        return 1 + InternalNodeCount(root.Left) + InternalNodeCount(root.Right);
    }

    public int ExternalNodeCount(Node? root)
    {
        if (root == null)
            return 0;
        if (root.Left == null && root.Right == null)
            return 1;
        return ExternalNodeCount(root.Left) + ExternalNodeCount(root.Right);

    }

    public static void Run()
    {
        var values = new int[] { 45, 39, 56, 12, 34, 78, 32, 10, 89, 54, 67, 81 };
        var bst = new BinarySearchTree();
        Node? root = bst.Create(values);

        int target = 67;
        bool isFound = bst.Search(root, target);
        Console.WriteLine($"Target {target} is found? {isFound}");
        
        target = 40;
        isFound = bst.Search(root, target);
        Console.WriteLine($"Target {target} is found? {isFound}");

        target = 56;
        _ = bst.Delete(root, target);
        // TODO: Visualization a tree
        bst.BreadthFirstTraversal(root);
        
        Console.WriteLine("\nMax Depth / Height : "+bst.MaxDepth(root));
        Console.WriteLine("Node Count : "+bst.NodeCount(root));
        Console.WriteLine("Internal Node Count : "+bst.InternalNodeCount(root));
        Console.WriteLine("External Node Count : "+bst.ExternalNodeCount(root));


    }
}