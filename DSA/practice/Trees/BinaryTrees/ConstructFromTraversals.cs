namespace DSA.practice.Trees.BinaryTrees;

public class ConstructFromTraversals
{
    public Node Construct(int[] inorder, int[] postorder)
    {
        if (inorder.Length == 0)
            return null;
        Node root = new Node(inorder[^1]);
        int i = inorder.Length-1;
        while (i >= 0)
        {
            if (postorder[i] == inorder[^1])
                break;
            i--;
        }

        root.Right = Construct(inorder[(i+1)..^1], postorder[..i]);
        root.Left = Construct(inorder[..i], postorder[..i]);
        return root;
    }

    public static void Run()
    {
        ConstructFromTraversals ct = new ConstructFromTraversals();
        int[] inorder = "DBHEIAFJCG".ToCharArray().Select( c => c-'A').ToArray();
        int[] postorder = "DHIEBJFGCA".ToCharArray().Select( c => c-'A').ToArray();
        Node tree = ct.Construct(inorder, postorder);
        Console.WriteLine(tree);
        
    }

}