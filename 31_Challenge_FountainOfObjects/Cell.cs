namespace _31_Challenge_FountainOfObjects;

// Holds Coordinates
public class Cell
{
    public int Row { get; }
    public int Column { get; }

    public Cell(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public override string ToString() => $"({Row},{Column})";
}

// Setup 2D array of Cells
public class Grid
{
    public int Rows { get; }
    public int Columns { get; }
    public Cell[,] Cells { get; }

    public Grid(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        Cells = new Cell[Rows, Columns];

        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                Cells[row, col] = new Cell(row, col);
            }
        }
    }

    public void Display()
    {
        for (int row = 0; row < Rows; row++)
        {
            Console.Write(" | ");
            for (int col = 0; col < Columns; col++)
            {
                Console.Write(Cells[row, col].ToString() + " | ");
            }
            Console.WriteLine();
        }
    }
}