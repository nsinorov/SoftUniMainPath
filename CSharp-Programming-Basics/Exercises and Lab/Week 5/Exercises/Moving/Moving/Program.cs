using System;

namespace Moving

{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * length * height;
            int totalbox = 0;

            while (true)
            {
                string box = Console.ReadLine();

                if (box == "Done")
                {
                    Console.WriteLine($"{volume - totalbox} Cubic meters left.");
                    break;
                }

                totalbox += int.Parse(box);

                if (volume <= totalbox)
                {
                    Console.WriteLine($"No more free space! You need {totalbox - volume} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
