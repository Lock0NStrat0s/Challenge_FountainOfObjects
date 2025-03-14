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
            runAgain = GameManager.RunApplication(mainGrid, player);
        } while (runAgain);
    }
}
