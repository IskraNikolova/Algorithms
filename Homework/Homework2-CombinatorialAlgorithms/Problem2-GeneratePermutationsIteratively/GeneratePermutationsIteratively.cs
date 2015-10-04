using System;
using System.Collections.Generic;

public class Program
{
    public static IEnumerable<int[]> Combinations(int m, int n)
    {
        int[] result = new int[m];
        Stack<int> stack = new Stack<int>();
        stack.Push(0);

        while (stack.Count > 0)
        {
            int index = stack.Count - 1;
            int value = stack.Pop();

            while (value < n)
            {
                result[index++] = value++;
                stack.Push(value);
                if (index == m)
                {
                    yield return result;
                    break;
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());

        foreach (int[] c in Combinations(k+1, n+1))
        {
            for (int i = 1; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();
        }
    }
}