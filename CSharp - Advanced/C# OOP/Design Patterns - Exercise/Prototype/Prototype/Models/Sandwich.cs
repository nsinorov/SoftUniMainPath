
namespace Prototype.Models;

public class Sandwich : SandwichPrototype
{
    private string bread;
    private string cheese;
    private string meat;
    private string veggies;

    public Sandwich(string bread, string cheese, string meat, string veggies)
    {
        this.bread = bread;
        this.cheese = cheese;
        this.meat = meat;
        this.veggies = veggies;
    }

    public override SandwichPrototype Clone()
    {
        Console.WriteLine($"Cloning sandwich with ingredients: {GetIngredients()}");

        return MemberwiseClone() as SandwichPrototype;
    }

    private string GetIngredients() => $"{bread}, {meat}, {cheese}, {veggies}";
}
