namespace DSA.practice.Trees.Tries;

public class Node
{
    public bool IsEnd { get; set; }

    public Dictionary<char, Node> Children
    {
        get;
        set;
    } = new();
}