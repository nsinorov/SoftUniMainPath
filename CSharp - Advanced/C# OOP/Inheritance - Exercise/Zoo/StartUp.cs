using System;

namespace Zoo
{
    public abstract class StartUp
    {
        public static void Main(string[] args)
        {
            Lizard lizard = new("Gosho");

            Console.WriteLine(lizard.Name);
        }
    }
}