using System.Text;

namespace DSA.practice.Trees.BinaryTrees;

public class Visualization
{
    public string Draw(Node node)
    {
        return Plot(node);
    }

    private int CalculateWidth(Node? node)
    {
        if (node == null)
        {
            return 0;
        }
        return 1 + CalculateWidth(node.Left)+ CalculateWidth(node.Right);
    }
    
    private string Plot(Node? root)
    {
        if (root == null)
            return "";
        StringBuilder sb = new StringBuilder();
        Queue<Node?> queue = new();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            Node? curr = queue.Dequeue();
            sb.Append("\n");
            sb.Append(curr?.Value).Append("\t");
            
            if(curr.Left != null)
                queue.Enqueue(curr.Left);
            if(curr.Right != null)
                queue.Enqueue(curr.Right);
        }

        return sb.ToString();
    }
}