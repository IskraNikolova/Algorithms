using System;

public class Area : IComparable<Area>
{
    private int size;
    private int row;
    private int column;
   
    public Area(int size, int row, int column)
    {
        this.Size = size;
        this.Row = row;
        this.Column = column;        
    }

    public int Size { get; set; }
    public int Row { get; set; }
    public int Column { get; set; }    

    public int CompareTo(Area other)
    {
        if (this.Size.CompareTo(other.Size) != 0)
        {
            return -1 * this.Size.CompareTo(other.Size);
        }

        if (this.Row.CompareTo(other.Row) != 0)
        {
            return this.Row.CompareTo(other.Row);
        }

        return this.Column.CompareTo(other.Column);
    }

    public override string ToString()
    {
       
        return $"({this.Row}, {this.Column}), size: {this.Size}";
    }
}

