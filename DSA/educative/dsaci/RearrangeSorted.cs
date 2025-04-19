namespace DSA.educative.dsaci;

/*
 * Implement a function maxMin(int arr[], int size), which takes a sorted array arr and its size and
 * will rearrange the elements of a sorted array such that the first position will have the largest number,
 * the second will have the smallest, the third will have second largest, and so on.
 * In other words, all the even-numbered indices will have the largest numbers in the array in descending order,
 * and the odd-numbered indices will have the smallest numbers in ascending order.
 */
public class RearrangeSorted
{
    public void Solution(ref int[] arr)
    {
        int size = arr.Length;
        int[] narr = new int[size];
        int pointerLarge = size - 1;
        int pointerSmall = 0;
        for (int i = 0; i < size; i++)
        {
            if (i % 2 == 0)
            {
                narr[i] = arr[pointerLarge--];
            }
            else
            {
                narr[i] = arr[pointerSmall++];
            }
        }
        arr = narr;
        
        // reference is passed by value; i.e. updates to array contents will be seen by caller but reassigning the array won't.
        // hence ref needs to be used.
    }

    public static void Run()
    {
        RearrangeSorted rs = new();
        int[] arr = [12, 23, 34, 45, 56, 67, 78];
        rs.Solution(ref arr);
        Console.WriteLine(string.Join(", ", arr));
        arr = [-22, -11, 1, 22, 33, 43, 55];
        rs.Solution(ref arr);
        Console.WriteLine(string.Join(", ", arr));

    }
}