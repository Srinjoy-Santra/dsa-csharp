namespace DSA.practice.Trees.Tries;

// https://leetcode.com/problems/implement-trie-prefix-tree/
public class Trie
{
    private Node _root;

    public Trie()
    {
        _root = new Node();
    }

    public void Insert(string word)
    {
        Node current = _root, child;
        foreach (char letter in word)
        {
            if (!current.Children.TryGetValue(letter, out child))
            {
                child = new Node();
                current.Children.Add(letter, child);
            }
            current = child;
        }

        current.IsEnd = true;
    }

    public bool Search(string word)
    {
        Node current = _root, child;
        foreach (char letter in word)
        {
            if (!current.Children.TryGetValue(letter, out child))
            {
                return false;
            }

            current = child;
        }

        return current.IsEnd;
    }

    public bool StartsWith(string word)
    {
        Node current = _root, child;
        foreach (char letter in word)
        {
            if (!current.Children.TryGetValue(letter, out child))
            {
                return false;
            }

            current = child;
        }

        return true;
    }
}