namespace Cars.Models;

public class Tesla : Car, IElectricCar
{

    public Tesla(string model, string color, int battery)
        : base(model, color)
    {
        Baterry = battery;
    }

    public int Baterry { get; }

    public override string ToString() => $"{Color} Tesla Model {Model} with {Baterry} Batteries";
}
