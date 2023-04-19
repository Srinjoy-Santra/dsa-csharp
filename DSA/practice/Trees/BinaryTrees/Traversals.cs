using DSA.practice.Trees.BinaryTrees;

namespace DSA.practice.Trees;

// More DFS, https://www.youtube.com/watch?v=jmy0LaGET1I&list=PLgUwDviBIf0q8Hkd7bK2Bpryj2xVJk8Vk&index=5

public class Traversals
{
    private void InOrder(Node? root)
    {
        if (root == null) return;

        InOrder(root.Left);
        Console.Write(root.Value + ", ");
        InOrder(root.Right);
    }
    
    private void PreOrder(Node? root)
    {
        if (root == null) return;
        Console.Write(root.Value + ", ");
        PreOrder(root.Left);
        PreOrder(root.Right);

    }
    
    private void PostOrder(Node? root)
    {
        if (root == null) return;
        PostOrder(root.Left);
        PostOrder(root.Right);
        Console.Write(root.Value + ", ");
    }

    public static void Run()
    {
        Node root = new Node(1);
        root.Left = new Node(2);
        root.Right = new Node(3);
        root.Left.Left = new Node(4);
        root.Left.Right = new Node(5);
        root.Right.Left = new Node(6);
        root.Right.Right = new Node(7);
        root.Left.Right.Left = new Node(8);
        root.Right.Right.Left = new Node(9);
        root.Right.Right.Right = new Node(10);

        Traversals t = new Traversals();
        Console.WriteLine(nameof(InOrder));
        t.InOrder(root);
        Console.WriteLine("\n"+nameof(PreOrder));
        t.PreOrder(root);
        Console.WriteLine("\n"+nameof(PostOrder));
        t.PostOrder(root);
    }
}