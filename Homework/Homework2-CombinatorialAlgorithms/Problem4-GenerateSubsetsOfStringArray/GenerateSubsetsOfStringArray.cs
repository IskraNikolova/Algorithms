using System;

public class GenerateSubsetsOfStringArray
{
    public static void Main()
    {
    
        string[] input = new[] {"test", "rock", "fun"};

        int k = 2;
        string[] combination = new string[k];


        GeneratingCombinations(combination, input, 0, 0);
    }

    private static void GeneratingCombinations(string[] combination, string[] input, int index, int startIndex)
    {
        if (index == combination.Length)
        {
            Console.WriteLine("(" + string.Join(" ", combination) + ")");
        }
        else
        {
            for (int i = startIndex; i < input.Length; i++)
            {
                combination[index] = input[i];
                GeneratingCombinations(combination, input, index + 1, i + 1);
            }
        }
    }
}

