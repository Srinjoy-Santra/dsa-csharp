namespace DSA.ctci;

/*
 Write a program to sort a stack such that the smallest items are on the 
 top. You can use an additional temporary stack, but you may not copy the
 elements into any other data structure (such as an array).
*/
public class SortStack
{
    private Stack<int> Sorted = new();
    private Stack<int> Temporary = new();

    public void Push(int num)
    {
        if (Sorted.Count == 0 || Sorted.Peek() > num)
        {
            Sorted.Push(num);
            return;
        }

        while (Sorted.Count > 0 && Sorted.Peek() < num)
        {
            Temporary.Push(Sorted.Pop());
        }
        
        Sorted.Push(num);

        while (Temporary.Count > 0)
        {
            Sorted.Push(Temporary.Pop());
        }
    }

    public int Pop()
    {
        return Sorted.Pop();
    }

    public int Peek()
    {
        return Sorted.Peek();
    }

    public bool IsEmpty()
    {
        return Sorted.Count == 0;
    }
}