
namespace DSA.ctci;

public class IsUnique
{
    public static bool Solution(string str)
    {
        bool[] checker = new bool[128];
        foreach (var c in str)
        {
            if (checker[c])
                return false;
            checker[c] = true;
        }

        return true;
    }
}