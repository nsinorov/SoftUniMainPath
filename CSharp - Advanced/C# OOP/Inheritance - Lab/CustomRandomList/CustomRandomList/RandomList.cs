
namespace CustomRandomList
{
    public class RandomList : List<string>
    {
     public string RandomString()
        {
            Random random = new();

            return this[random.Next(0, Count)];
        }
    }
}
