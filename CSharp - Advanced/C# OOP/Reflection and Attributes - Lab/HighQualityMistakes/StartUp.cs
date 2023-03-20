namespace Stealer;

class StartUp
{
    public static void Main(string[] args)
    {
        var spy = new Spy();
        var result = spy.AnalyzeAcessModifiers("Hacker");

        Console.WriteLine(result);
    }
}