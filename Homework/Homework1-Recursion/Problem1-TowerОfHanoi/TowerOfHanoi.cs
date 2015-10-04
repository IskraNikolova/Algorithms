using System;
using System.Collections.Generic;
using System.Linq;

public class TowerOfHanoi
{
    private  static int stepsTaken = 0;

    private static Stack<int> source;
    private static readonly Stack<int> destination = new Stack<int>();
    private static readonly Stack<int> spare = new Stack<int>();

    public static void Main()
    {
        Console.Write("Write number of disks: ");
        int numberOfDisks = int.Parse(Console.ReadLine());

        source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
        PrintPegs();

        MoveDisks(numberOfDisks, source, destination, spare);
    }

    private static void PrintPegs()
    {
        Console.WriteLine("Sourse: {0}", string.Join(", ", source.Reverse()));
        Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
        Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
        Console.WriteLine();
    }

    private static void MoveDisks(int bottomDisk, Stack<int> sourceR, Stack<int> destinationR, Stack<int> spareR)
    {
       
        if (bottomDisk == 1)
        {
            stepsTaken++;
            destinationR.Push(sourceR.Pop());
            Console.WriteLine($"Step #{stepsTaken}: Moved disk {bottomDisk}");
            PrintPegs();
        
        }
        else
        {
         
            MoveDisks(bottomDisk - 1, sourceR, spareR, destinationR);
            stepsTaken++;
            destinationR.Push(sourceR.Pop());
            Console.WriteLine($"Step #{stepsTaken}: Moved disk {bottomDisk}");
            PrintPegs();
            MoveDisks(bottomDisk - 1, spareR, destinationR, sourceR);  
        }
        
    }
}

