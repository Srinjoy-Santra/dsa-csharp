namespace DSA.ctci;

public class URLify
{
    public static void Solution(char[] carr, int trueLength)
    {
        int spaceCount = 0;
        for(int i=0;i<trueLength;i++)
        {
            if (carr[i] == ' ')
                spaceCount++;
        }

        int index = spaceCount * 2 + trueLength;

        if (trueLength < carr.Length) carr[trueLength] = '\0';
        
        for (int i = trueLength - 1; i >= 0; i--)
        {
            if (carr[i] == ' ')
            {
                carr[--index] = '0';
                carr[--index] = '2';
                carr[--index] = '%';
            }
            else
            {
                carr[--index] = carr[i];
            }
        }
    }
}