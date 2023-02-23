namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            stack.AddRange(args);
            stack.IsEmpty();
        }
    }
}