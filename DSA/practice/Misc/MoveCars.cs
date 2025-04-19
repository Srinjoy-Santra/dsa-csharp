namespace DSA.practice.Misc;

/*
 * u are given a row of car parking
 * where 0 means free
 * initial configuration:
10234

final configuration

23014

print all the steps to move initial to final 
note: every step u can move one car to the free slot
 */

public class MoveCars
{
    public static void Run()
    {
        var initial = new[] { 1, 0, 2, 3, 4 };
        var final = new[] { 2, 3, 0, 1, 4 };

        MoveCars m = new();
        m.Move(initial, final);

    }

    private void Move(int[] initial, int[] final)
    {
        Print(initial);
        for (int i = initial.Length-1; i >= 0; i--)
        for (int j = i - 1; j < initial.Length; j--)
        {
            while (initial[i] > final[i])
            {
                initial[i]--;
                initial[j]++;
                Print(initial);
            }
        }
    }

    private void Print(int[] arr)
    {
        foreach (var ele in arr)
        {
            Console.Write(ele + ",");
        }
        Console.WriteLine();
    }

}

/*
 * {
            int j = i+1;
            while (initial[i] < final[i])
            {
                if (initial[j] > 0)
                {
                    initial[i]++;
                    initial[j]--;
                    Print(initial);
                }

                j++;
            }
        }
*/