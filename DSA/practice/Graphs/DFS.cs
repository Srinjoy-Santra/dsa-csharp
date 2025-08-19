namespace DSA.practice.Graphs;

public partial class Graph<T>
{
    public List<Node<T>> DFS()
    {
        bool[] isVisited = new bool[Nodes.Count];
        List<Node<T>> result = [];
        DFS(isVisited, Nodes[0], result);
        return result;
    }

    private void DFS(bool[] isVisited, Node<T> node, List<Node<T>> result)
    {
        
        result.Add(node);
        isVisited[node.Index] = true;
        
        foreach (Node<T> neighbour in node.Neighbours)
        {
            if(!isVisited[neighbour.Index])
                DFS(isVisited, neighbour, result);
        }
    }
}