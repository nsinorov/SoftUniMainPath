using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupNumbers = int.Parse(Console.ReadLine());
            int musala = 0;
            int montBlanc = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;
            int alpinistSum = 0;

            for (int i = 0; i < groupNumbers; i++)
            {
                int currentGroup = int.Parse(Console.ReadLine());
                alpinistSum += currentGroup;

                if (currentGroup > 40)
                {
                    everest += currentGroup;
                }
                else if (currentGroup > 25)
                {
                    k2 += currentGroup;
                }
                else if (currentGroup > 12)
                {
                    kilimanjaro += currentGroup;
                }
                else if (currentGroup > 5)
                {
                    montBlanc += currentGroup;
                }
                else if (currentGroup > 0)
                {
                    musala += currentGroup;
                }
            }
            Console.WriteLine($"{100.0 * musala / alpinistSum:f2}%");
            Console.WriteLine($"{100.0 * montBlanc / alpinistSum:f2}%");
            Console.WriteLine($"{100.0 * kilimanjaro / alpinistSum:f2}%");
            Console.WriteLine($"{100.0 * k2 / alpinistSum:f2}%");
            Console.WriteLine($"{100.0 * everest / alpinistSum:f2}%");
        }
    }
}
