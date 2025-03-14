namespace _31_Challenge_FountainOfObjects;

abstract class GridPiece
{
    public abstract Cell Location { get; }
    public abstract string Sense { get; }
}

class Fountain : GridPiece
{
    public override Cell Location => new Cell(0, 2);

    public override string Sense => "You hear the rushing waters from the Fountain of Objects.";
}

class Entrance : GridPiece
{
    public override Cell Location => new Cell(0, 0);

    public override string Sense => "You see light coming from the cavern entrance";
}
