namespace DSA.practice.Graphs;

public partial class Graph<T>
{
    public List<Node<T>> BFS() => BFS(Nodes[0]);

    private List<Node<T>> BFS(Node<T> node)
    {
        bool[] isVisited = new bool[Nodes.Count];
        isVisited[node.Index] = true;
        
        List<Node<T>> result = [];
        Queue<Node<T>> queue = [];
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var next = queue.Dequeue();
            result.Add(next);
            foreach (var neighbour in next.Neighbours)
            {
                if (!isVisited[neighbour.Index])
                {
                    isVisited[neighbour.Index] = true;
                    queue.Enqueue(neighbour);
                }
            }
        }
        return result;
    }
}