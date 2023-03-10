
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals;

public class Cat : Feline
{
    private const double CatWeightMultiplier = 0.30;
    public Cat(string name, double weight, string livingRegion, string breed) 
        : base(name, weight, livingRegion, breed)
    {
    }

    public override double WeightMultiplier => CatWeightMultiplier;

    public override IReadOnlyCollection<Type> PreferredFoods => new HashSet<Type> { typeof(Meat), typeof(Vegetable) };

    public override string ProduseSound() => "Meow";
}
