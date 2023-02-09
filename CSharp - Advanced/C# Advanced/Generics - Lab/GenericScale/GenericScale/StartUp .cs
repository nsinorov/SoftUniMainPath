namespace GenericScale;

public class StartUp
{
    public static void Main(string[] args)
    {
        EqualityScale<int> scale = new EqualityScale<int>(11, 111);
        Console.WriteLine(scale.AreEqual());

      // Console.WriteLine(scale.GetBigger());
    }
}