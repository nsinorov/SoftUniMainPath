using Shapes;

public class StartUp
{
    static void Main(string[] args)
    {
        Rectangle rect = new(10, 20);

        Console.WriteLine(rect.CalculatePerimeter());
        Console.WriteLine(rect.CalculateArea());

        Circle circle = new(30);

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());

        Console.WriteLine(rect.Draw());
        Console.WriteLine(circle.Draw());
    }
}
