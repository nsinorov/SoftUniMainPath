
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals;

public class Tiger : Feline
{
    private const double TigerWeightMultiplier = 1;
    public Tiger(string name, double weight, string livingRegion, string breed) 
        : base(name, weight, livingRegion, breed)
    {
    }

    public override double WeightMultiplier => TigerWeightMultiplier;

    public override IReadOnlyCollection<Type> PreferredFoods => new HashSet<Type> { typeof(Meat) };

    public override string ProduseSound() => "ROAR!!!";
}
