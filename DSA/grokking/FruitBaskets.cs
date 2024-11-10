namespace DSA.grokking;

// https://leetcode.com/problems/fruit-into-baskets/description/
public class FruitBaskets
{
    // MyTotalFruit : wrong
    public int MyTotalFruit(int[] fruits) {
        Dictionary<int, int> baskets = new();
        int start = 0, maxFruits = 0;
        baskets[fruits[start]] = 1;
        for(int end = 1; end<fruits.Length;end++)
        {
            int fruit = fruits[end];
            if(baskets.ContainsKey(fruit))
            {
                baskets[fruit]++;
            } else if (baskets.Count == 2){
                int sf = fruits[start];
                start += baskets[sf];
                baskets.Remove(sf);
                baskets[fruit] = 1;
            } else {
                baskets[fruit] = 1;
            }

            int fruitCount = 0;
            foreach(var pair in baskets)
            {
                fruitCount += pair.Value;
            }
            maxFruits = Math.Max(maxFruits, fruitCount);
        }

        return maxFruits;
    }
    
    public int TotalFruit(int[] fruits) {
        Dictionary<int, int> baskets = new();
        int start = 0, maxFruits = 0;
        for(int end = 0; end<fruits.Length;end++)
        {
            int fruit = fruits[end];
            baskets[fruit] = baskets.GetValueOrDefault(fruit, 0) + 1;
            while (baskets.Count > 2){
                int sf = fruits[start];
                baskets[sf]--;
                if (baskets[sf] == 0)
                {
                    baskets.Remove(sf);
                }
                start++;
            }

            int fruitCount = end - start + 1;
            Console.WriteLine($"{start}, {end}, {fruitCount}, {maxFruits}");
            maxFruits = Math.Max(maxFruits, fruitCount);
        }

        return maxFruits;
    }

    public static void Run()
    {
        FruitBaskets fb = new();
        int op= fb.TotalFruit(new[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 });
        Console.WriteLine(op);
    }
}