namespace _31_Challenge_FountainOfObjects;

// Holds Coordinates
class Cell
{
    public int Row { get; private set; }
    public int Column { get; private set; }

    public Cell(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public void UpdateRow(int newRow, int newColumn)
    {
        Row = newRow;
        Column = newColumn;
    }

    public override string ToString() => $"({Row},{Column})";
}

// Setup 2D array of Cells
class Grid
{
    public int Rows { get; }
    public int Columns { get; }
    public Cell[,] Cells { get; }
    public List<GridPiece> GridPieces { get; } = new();
    public FountainState Fountain { get; private set; } = FountainState.Disabled;

    public Grid(int rows, int columns)
    {
        // Create grid
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

        // Create grid pieces
        GridPieces.Add(new Entrance());
        GridPieces.Add(new Fountain());

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

    public void EnableFountain()
    {
        Fountain = FountainState.Enabled;
    }
}

enum FountainState
{
    Enabled, Disabled
}