using System;

public class NestedLoopsToRecursion
{
    public static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] combination = new int[n];

        int startNumber = 1;
        int endNumber = n;

        GeneratingCombinations(combination, 0, startNumber,  endNumber);
    }

    private static void GeneratingCombinations(int[] combination, int index, int startNumber, int endNumber)
    {
        if (index >= combination.Length)
        {
            Console.WriteLine(string.Join(" ", combination));
        }
        else
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                combination[index] = i;
                GeneratingCombinations(combination, index + 1, startNumber, endNumber);
            }
        }
    }
}

