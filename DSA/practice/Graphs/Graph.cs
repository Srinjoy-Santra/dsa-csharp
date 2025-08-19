namespace DSA.practice.Graphs;

public partial class Graph<T>
{
    public required bool IsDirected { get; init; }
    public required bool IsWeighted { get; init; }
    public List<Node<T>> Nodes { get; set; } = [];
    
    public Node<T> AddNode(T value)
    {
        Node<T> node = new() {Data = value};
        Nodes.Add(node);
        UpdateIndices();
        return node;
    }

    public void RemoveNode(Node<T> node)
    {
        Nodes.Remove(node);
        UpdateIndices();
        Nodes.ForEach(n => RemoveEdge(n, node));
        //Nodes.ForEach(n => n.Neighbours.Remove(node));
    }

    public void UpdateIndices()
    {
        int i = 0;
        Nodes.ForEach(n => n.Index = i++);
    }
    
    public Edge<T>? this[int from, int to]
    {
        get
        {
            Node<T> nodeFrom = Nodes[from];
            Node<T> nodeTo = Nodes[to];
            int i = nodeFrom.Neighbours.IndexOf(nodeTo);
            if (i < 0)
            {
                return null;
            }

            Edge<T> edge = new()
            {
                From = nodeFrom,
                To = nodeTo,
                Weight = i < nodeFrom.Neighbours.Count ? nodeFrom.Weights[i] : 0
            };
            return edge;
        }
    }
    
    public void AddEdge(Node<T> from, Node<T> to, int w = 0)
    {
        from.Neighbours.Add(to);
        if (IsWeighted)
        {
            from.Weights.Add(w);
        }

        if (!IsDirected)
        {
            to.Neighbours.Add(from);
            if (IsWeighted)
            {
                to.Weights.Add(w);
            }
        }
    }

    public void RemoveEdge(Node<T> from, Node<T> to)
    {
        int index = from.Neighbours.FindIndex(n => n == to);
        // int index = from.Neighbours.IndexOf(to); // why not
        if (index < 0) return;
        from.Neighbours.RemoveAt(index);
        if (IsWeighted)
        {
            from.Weights.RemoveAt(index);
        }

        if (!IsDirected)
        {
            index = to.Neighbours.FindIndex(n => n == from);
            if (index < 0) return;
            to.Neighbours.RemoveAt(index);
            if (IsWeighted) to.Weights.RemoveAt(index);
        }
    }

    public List<Edge<T>> GetEdges()
    {
        List<Edge<T>> edges = [];
        foreach (Node<T> from in Nodes)
        {
            for (int i = 0; i < from.Neighbours.Count; i++)
            {
                int weight = i < from.Weights.Count ? from.Weights[i] : 0;
                Edge<T> edge = new()
                {
                    From = from,
                    To = from.Neighbours[i],
                    Weight = weight
                };
                edges.Add(edge);
            }
        }

        return edges;
    }
    
}

public class Node<T>
{
    public int Index { get; set; }
    public required T Data { get; set; }
    public List<Node<T>> Neighbours { get; set; } = [];
    public List<int> Weights { get; set; } = [];
    public override string ToString() => $"{Index} = {Data}; Neighbours: {Neighbours.Count}";
}

public class Edge<T>
{
    public required Node<T> From { get; set; }
    public required Node<T> To { get; set; }
    public int Weight { get; set; }
    public override string ToString() => $"{From.Data} -> {To.Data}; Weight: {Weight}";
}

