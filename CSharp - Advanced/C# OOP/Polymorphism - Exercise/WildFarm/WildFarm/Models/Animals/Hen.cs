

using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals;

public class Hen : Bird
{
    private const double HenWeightMultiplier = 0.35;

    public Hen(string name, double weight, double wingSize) 
        : base(name, weight, wingSize)
    {

    }

    public override double WeightMultiplier => HenWeightMultiplier;

    public override IReadOnlyCollection<Type> PreferredFoods => new HashSet<Type> { typeof(Meat), typeof(Fruit), typeof(Seeds), typeof(Vegetable) };

    public override string ProduseSound() => "Cluck";
}
