using System.Text;

namespace DSA.leetcode;

// https://leetcode.com/problems/combination-sum/

public class CombinationSum
{
    public static IList<IList<int>> Solution(int[] candidates, int target) {
        IList<IList<int>> targetedCombinations = new List<IList<int>>();
        IList<int> currentCombination = new List<int>();
        int index= 0;
        
        TraverseCombinations(candidates, target, index,  currentCombination,  targetedCombinations);
        Console.WriteLine("=>"+targetedCombinations.Count);
        Print(targetedCombinations, currentCombination);
        return targetedCombinations;
    }
    
    private static void TraverseCombinations(int[] candidates, int target, int index,  IList<int> currentCombination,  IList<IList<int>> targetedCombinations) 
    {
        if(index == candidates.Length)
        {
            if(target == 0)
            {
                // copy the value, instead of assigning the erence
                targetedCombinations.Add(new List<int>(currentCombination));
                //Console.WriteLine(string.Join(",", currentCombination));
                //Print(targetedCombinations);

            }
            return;
        }
        int candidate = candidates[index];
        if (target >= candidate)
        {
            currentCombination.Add(candidate);
            //Print(targetedCombinations, currentCombination,35);
            TraverseCombinations(candidates, target-candidate, index,  currentCombination,  targetedCombinations);
            //Print(targetedCombinations, currentCombination, 37 );
            currentCombination.RemoveAt(currentCombination.Count - 1);
            //Console.WriteLine("="+targetedCombinations.Count);
        }
        //Print(targetedCombinations, currentCombination, 41);
        TraverseCombinations(candidates, target, index+1,  currentCombination,  targetedCombinations);
       
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
        int[] candidates = { 2,3,6,7 };
        int target = 7;
        _ = Solution(candidates, target);
    }
}