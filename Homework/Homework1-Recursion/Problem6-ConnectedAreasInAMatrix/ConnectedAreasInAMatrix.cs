using System;
using System.Collections.Generic;

public class ConnectedAreaInMatrix
{

    private static SortedSet<Area> foundAreas = new SortedSet<Area>();
    private static int size = 0;
    public static List<char[]> matrix = new List<char[]>();

    public static void Main()
    {

        matrix.Add(new[] {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '});
        matrix.Add(new[] {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '});
        matrix.Add(new[] {'*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' '});
        matrix.Add(new[] {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '});
        matrix.Add(new[] {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '});

        FindTheFirstCell();
        int numberArea = 1;
        foreach (var area in foundAreas)
        {
            Console.WriteLine("Area #{0} at {1}", numberArea, area);
            numberArea++;
        }

    }

    private static void FindTheFirstCell()
    {
        for (int row = 0; row < matrix.Count; row++)
        {
            for (int column = 0; column < matrix[row].Length; column++)
            {
                if (matrix[row][column] == ' ')
                {
                    RecordCells(row, column);
                    foundAreas.Add(new Area(size, row, column));
                    size = 0;
                }
            }
        }
    }

   public static void  RecordCells(int row, int column)
   {
  
        if (row < 0 || column < 0 ||
            row >= matrix.Count || column >= matrix[row].Length)
        {
            return;
        }
        if (matrix[row][column] == 'x' || matrix[row][column] == '*')
        {
            return;
        }


        matrix[row][column] = 'x';
        size++;

        RecordCells(row, column + 1);
        RecordCells(row, column - 1);
        RecordCells(row + 1, column);
        RecordCells(row - 1, column);
    }

 
}


