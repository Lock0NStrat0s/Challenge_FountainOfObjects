namespace _31_Challenge_FountainOfObjects;

public class Player
{
    public int Row { get; private set; }
    public int Column { get; private set; }
    public Cell currentPosition { get; private set; }

    public Player(int row = 0, int column = 0)
    {
        Row = row;
        Column = column;
        currentPosition = new Cell(row, column);
    }

    // Attempts to move the player in the given direction on the provided grid.
    // Returns true if the move is successful, false if the move is out of bounds.
    public void PlayerAction(Action direction, Grid grid)
    {
        int newRow = Row;
        int newColumn = Column;

        switch (direction)
        {
            case Action.Up:
                newRow--;
                Move(grid, newRow, newColumn);
                break;
            case Action.Down:
                newRow++;
                Move(grid, newRow, newColumn);
                break;
            case Action.Right:
                newColumn++;
                Move(grid, newRow, newColumn);
                break;
            case Action.Left:
                newColumn--;
                Move(grid, newRow, newColumn);
                break;
            case Action.Enable:
                Enable(grid);
                break;
        }

        
    }

    private void Enable(Grid grid)
    {
        if (currentPosition.Row == 0 && currentPosition.Column == 2)
        {
            grid.EnableFountain();
            Console.WriteLine("Fountain enabled.");
        }
        else
        {
            Console.WriteLine("You are not at the fountain.");
        }
    }

    private void Move(Grid grid, int newRow, int newColumn)
    {
        // Check if the new position is within grid bounds
        if (newRow < 0 || newRow >= grid.Rows || newColumn < 0 || newColumn >= grid.Columns)
        {
            Console.WriteLine("Move is invalid (out of bounds)");
        }
        else
        {
            // Update player's position
            Row = newRow;
            Column = newColumn;
            currentPosition.UpdateRow(Row, Column);
        }
    }
}

public enum Action
{
    Up, Down, Right, Left, Enable
}

