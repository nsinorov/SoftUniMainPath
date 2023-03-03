namespace Cars.Models;

public class Seat : Car
{
    public Seat(string model, string color)
        : base(model, color)
    {
    }

    public override string ToString() => $"{Color} Seat {Model}";
}
