using System;

public class PermutationWithRepetition
{
    public static void Main()
    {
        int[] arr = new[] {1, 3, 5, 5};
        Array.Sort(arr);
        PermuteRep(arr, 0, arr.Length - 1);
    }

    static void PermuteRep(int[] arr, int start, int end)
    {
        Console.WriteLine("{" + string.Join(", ", arr) + "}");
        for (int left = end - 1; left >= start; left--)
        {
            for (int right = left + 1; right <= end; right++)
            {
                if (arr[left] != arr[right])
                {
                    Swap(ref arr[left], ref arr[right]);
                    PermuteRep(arr, left + 1, end);
               }             
            }
            var firstElement = arr[left];
            for (int i = left; i <= end - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[end] = firstElement;
        }
    }
    private static void Swap(ref int j, ref int i)
    {
        int old = j;
        j = i;
        i = old;
    }
}

