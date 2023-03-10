
namespace WildFarm.Models.Interfaces;

public interface IAnimal
{
    public string Name { get; }
    public double Weight { get; }
    public int FoodEaten { get; }

    string ProduseSound();

    void Eat(IFood food);


}
