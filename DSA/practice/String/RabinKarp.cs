namespace DSA.practice.String;

// DSA/leetcode/IndexOfFirstOccurenceInString.cs
public class RabinKarp
{
    public bool Search(string text, string pattern)
    {
        double patternHash = CreateRollingHash(pattern);
        double textHash = 0;
        for (int i = 0; i < text.Length; i++)
        {
            textHash = textHash*10 + text[i];
            if (i >= pattern.Length - 1)
            {
                if (textHash == patternHash)
                {
                    return true;
                }
                textHash -= text[i+1 - pattern.Length]*Math.Pow(10, pattern.Length-1);
            }
        }

        return false;
    }

    private double CreateRollingHash(string pattern)
    {
        double hash =0;
        for (int i=0;i<pattern.Length;i++)
        {
            hash = hash*10 + pattern[i];
        }

        return hash;
    }

    public static void Main()
    {
        string text = "ccaccaaedba";
        string pattern = "dba";
        RabinKarp rk = new();
        Console.WriteLine(rk.Search(text, pattern));
    }
}