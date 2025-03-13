namespace _31_Challenge_FountainOfObjects;

internal class Program
{
    static void Main(string[] args)
    {
        Grid mainGrid = new Grid(5, 5);
        Player player = new Player();
        bool runAgain = true;

        do
        {
            if (player.currentPosition.Row == 0 && player.currentPosition.Column == 0 && mainGrid.Fountain == FountainState.Enabled)
            {
                Console.WriteLine("CONGRATS!");
                runAgain = false;
            }
            else
            {
                Console.Clear();
                mainGrid.Display();
                Console.WriteLine($"You are in the room at {player.currentPosition.ToString()}.");
                Console.WriteLine("You see light coming from the cavern entrance.");
                Console.Write("What do you want to do? ");
                switch (Console.ReadLine().ToLower())
                {
                    case "east":
                        player.PlayerAction(Action.Right, mainGrid);
                        break;
                    case "west":
                        player.PlayerAction(Action.Left, mainGrid);
                        break;
                    case "north":
                        player.PlayerAction(Action.Up, mainGrid);
                        break;
                    case "south":
                        player.PlayerAction(Action.Down, mainGrid);
                        break;
                    case "enable":
                        player.PlayerAction(Action.Enable, mainGrid);
                        break;
                    default:
                        runAgain = false;
                        break;
                }
            }
        } while (runAgain);
    }
}
