namespace _31_Challenge_FountainOfObjects;

class GameManager
{
    public static bool RunApplication(Grid mainGrid, Player player)
    {
        // win condition
        if (player.Position.Row == 0 && player.Position.Column == 0 && mainGrid.Fountain == FountainState.Enabled)
        {
            "CONGRATS!".PrintColour(ConsoleColor.Blue);
            return false;
        }
        else
        {
            return DisplayConsole(mainGrid, player);
        }
    }

    private static bool DisplayConsole(Grid mainGrid, Player player)
    {
        Console.Clear();
        mainGrid.Display();
        Console.WriteLine($"You are in the room at {player.Position.ToString()}.");
        player.MySense(mainGrid).PrintColour(ConsoleColor.DarkYellow);
        Console.Write("What do you want to do? ");
        return UserAction(mainGrid, player);
    }

    private static bool UserAction(Grid mainGrid, Player player)
    {
        switch (Console.ReadLine().ToLower())
        {
            case "east":
                player.PlayerAction(_31_Challenge_FountainOfObjects.Action.Right, mainGrid);
                break;
            case "west":
                player.PlayerAction(_31_Challenge_FountainOfObjects.Action.Left, mainGrid);
                break;
            case "north":
                player.PlayerAction(_31_Challenge_FountainOfObjects.Action.Up, mainGrid);
                break;
            case "south":
                player.PlayerAction(_31_Challenge_FountainOfObjects.Action.Down, mainGrid);
                break;
            case "enable":
                player.PlayerAction(_31_Challenge_FountainOfObjects.Action.Enable, mainGrid);
                break;
            default:
                return false;
        }

        return true;
    }
}
