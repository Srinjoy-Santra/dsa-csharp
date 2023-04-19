using System.Text;

namespace DSA.leetcode;

// https://leetcode.com/problems/combination-sum-ii/

public class CombinationSum2
{
    public static IList<IList<int>> Solution(int[] candidates, int target) {
        var targetedCombinations = new List<List<int>>();
        IList<int> currentCombination = new List<int>();
        int index=0;
        Array.Sort(candidates);
        FindCombinations(candidates, target, index, currentCombination, targetedCombinations);
        return new List<IList<int>>(targetedCombinations);
    }
    
    private static void FindCombinations(int[] candidates, int target, int index,  IList<int> currentCombination,  IList<List<int>>targetedCombinations) 
    {
        if(target == 0)
        {
            targetedCombinations.Add(new List<int>(currentCombination));
        }
        else
        {
            // Depth-first search
            for (int i = index; i < candidates.Length; i++)
            {
                if (i > index && candidates[i - 1] == candidates[i])
                    continue;
                int candidate = candidates[i];
                if (target - candidate < 0) break;
                currentCombination.Add(candidate);
                FindCombinations(candidates, target - candidate, i + 1, currentCombination, targetedCombinations);
                currentCombination.RemoveAt(currentCombination.Count-1);
            }
        }
    }
    
    private static void Print(IList<IList<int>> combinations, IList<int> currentCombination, int lineNum=0)
    {
        Console.WriteLine("Print "+lineNum);
        if(currentCombination.Count > 0)
            Console.WriteLine("current =" + string.Join(",", currentCombination));

        StringBuilder sb = new();
        foreach(var combination in combinations)
        {
            sb.Append("["+string.Join(",", combination)+"]");
        }
        Console.WriteLine("Overall = "+sb);
    }

    public static void Run()
    {
        int[] candidates =
        {
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1
        };
        int target = 30;
        Print(Solution(candidates, target), new List<int>());
    }
}