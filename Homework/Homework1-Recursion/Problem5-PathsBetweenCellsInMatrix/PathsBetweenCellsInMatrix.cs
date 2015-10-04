using System;
using System.Collections.Generic;


public class PathsBetweenCellsInMatrix
 {
  
    private static  List<char> path = new List<char>();
    private static int pathFound = 0;
    public static void Main()
    {
        //List<char[]> lab = new List<char[]>();
        //while (true)
        //{
        //    string input = Console.ReadLine();
        //    if (input == String.Empty)
        //    {
        //        break;
        //    }
        //   lab.Add(input.ToCharArray());

        //}

         List<char[]> lab = new List<char[]>();
        
         lab.Add(new[] {'s', ' ', ' ', ' '});
         lab.Add(new[] {' ', '*', '*', ' '});
         lab.Add(new[] {' ', '*', '*', ' '});
         lab.Add(new[] {' ', '*', 'e', ' '});
         lab.Add(new[] {' ', ' ', ' ', ' '});
        
        FinfExit(lab, 0, 0, ' ');
        Console.WriteLine("Total paths found: {0}", pathFound);
    }

     private static void FinfExit(List<char[]>lab, int row, int column, char dir)
     {

         if (row < 0 || column < 0 || 
            row >= lab.Count || column >= lab[row].Length)
         {
             return;
         }

         if (lab[row][column] == 'e')
         {
            path.Remove(path[0]);
            path.Add(dir);
            Console.WriteLine(string.Join("", path));
            pathFound++;
            return;
         }

         if (lab[row][column] != 's' && lab[row][column] != ' ')
         {
             return;
         }
         lab[row][column] = 'x';
         path.Add(dir);

         FinfExit(lab, row, column + 1, 'R');
         FinfExit(lab, row, column - 1, 'L');
         FinfExit(lab, row + 1, column, 'D');
         FinfExit(lab, row - 1, column, 'U');

         lab[row][column] = ' ';
         path.RemoveAt(path.Count  - 1);
        
     }
 }

