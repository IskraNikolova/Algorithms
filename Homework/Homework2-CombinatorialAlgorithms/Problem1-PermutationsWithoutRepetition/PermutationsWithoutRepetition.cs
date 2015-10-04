using System;
using System.Linq;

public class PermutationsWithoutRepetition
{
    //Write a recursive program for generating and printing all permutations (without repetition) of the numbers 1, 2, ..., n 
    //for a given integer number n (n > 0).
    private static int countOfPermutation = 0;
    public static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        var array = Enumerable.Range(1, n).ToArray();
        Permutation(array, 0);
        Console.WriteLine($"Total permutation: {countOfPermutation}");
    }

    private static void Permutation(int[] arr, int k = 0)
    {
        if (k >= arr.Length - 1)
        {
            Console.WriteLine(string.Join(", ", arr));
            countOfPermutation++;
        }
        else
        {
            for (int i = k; i < arr.Length; i++)
            {
                Swap(ref arr[k], ref arr[i]);
                Permutation(arr, k + 1);
                Swap(ref arr[k], ref arr[i]);
            }

        }
    }

    private static void Swap(ref int j, ref int i)
    {
        if (j == i)
        {
            return;
        }
        i ^= j;
        j ^= i;
        i ^= j;
    }
}

