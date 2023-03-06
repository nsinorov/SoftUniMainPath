

namespace Animals;

public abstract class Animal
{
    protected Animal(string name, string favouriteFood)
    {
        Name = name;
        FavouriteFood = favouriteFood;
    }

    public string Name { get; set; }
    public string FavouriteFood { get; set; }
    public virtual string ExplainSelf()
    {
        return "";
    }
}
