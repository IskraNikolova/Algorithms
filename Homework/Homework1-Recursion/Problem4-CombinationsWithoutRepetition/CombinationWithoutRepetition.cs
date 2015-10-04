using System;

public class CombinationsWithRepetition
{
    public static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int[] combination = new int[k];

        int endNumber = n;

        GeneratingCombinations(combination, 0, 1, endNumber);
    }

    private static void GeneratingCombinations(int[] combination, int index, int startNumber, int endNumber)
    {
        if (index >= combination.Length)
        {
            Console.WriteLine("(" + string.Join(" ", combination) + ")");
        }
        else
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                combination[index] = i;
                GeneratingCombinations(combination, index + 1, i + 1, endNumber);
            }
        }
    }
}
