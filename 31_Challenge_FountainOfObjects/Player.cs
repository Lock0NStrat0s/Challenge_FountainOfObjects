namespace _31_Challenge_FountainOfObjects;

class Player
{
    public Cell Position { get; private set; }

    public Player(int row = 0, int column = 0)
    {
        Position = new Cell(row, column);
    }

    // Attempts to move the player in the given direction on the provided grid.
    // Returns true if the move is successful, false if the move is out of bounds.
    public void PlayerAction(Action direction, Grid grid)
    {
        int newRow = Position.Row;
        int newColumn = Position.Column;

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
        if (Position.Row == 0 && Position.Column == 2)
        {
            grid.EnableFountain();
            "Fountain enabled.".PrintColour(ConsoleColor.Magenta);
        }
        else
        {
            "You are not at the fountain.".PrintColour(ConsoleColor.Red);
        }
    }

    private void Move(Grid grid, int newRow, int newColumn)
    {
        // Check if the new position is within grid bounds
        if (newRow < 0 || newRow >= grid.Rows || newColumn < 0 || newColumn >= grid.Columns)
        {
            "Move is invalid (out of bounds)".PrintColour(ConsoleColor.Red);
        }
        else
        {
            // Update player's position
            Position.UpdateRow(newRow, newColumn);
        }
    }

    public string MySense(Grid grid)
    {
        foreach (GridPiece item in grid.GridPieces)
        {
            if (item.Location.Row == Position.Row && item.Location.Column == Position.Column)
            {
                return item.Sense;
            }
        }

        return "NONE";
    }
}

enum Action
{
    Up, Down, Right, Left, Enable
}

