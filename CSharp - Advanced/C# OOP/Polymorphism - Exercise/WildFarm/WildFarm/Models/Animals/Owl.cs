

using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals;

public class Owl : Bird
{
    private const double OwlWeightMultiplier = 0.25;

    public Owl(string name, double weight, double wingSize) 
        : base(name, weight, wingSize)
    {

    }

    public override double WeightMultiplier => OwlWeightMultiplier;

    public override IReadOnlyCollection<Type> PreferredFoods => new HashSet<Type> { typeof(Meat)};

    public override string ProduseSound() => "Hoot Hoot";
}
