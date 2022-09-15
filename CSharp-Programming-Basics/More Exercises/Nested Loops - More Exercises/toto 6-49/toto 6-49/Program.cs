using System;

namespace toto_6_49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i1 = 1; i1 <= 44; i1++)
            {
                sum += i1;
                for (int i2 = i1 + 1; i2 <= 45; i2++)
                {
                    sum += i2;
                    for (int i3 = i2 + 1; i3 <= 46; i3++)
                    {
                        sum += i3;
                        for (int i4 = i3 + 1; i4 <= 47; i4++)
                        {
                            sum += i4;
                            for (int i5 = i4 + 1; i5 <= 48; i5++)
                            {
                                sum += i5;
                                for (int i6 = i5 + 1; i6 <= 49; i6++)
                                {
                                    sum += i6;
                                    Console.WriteLine($"{i1} {i2} {i3} {i4} {i5} {i6}");
                                }
                            }
                        }
                    }
                }
            }
           // Console.WriteLine(sum);
        }
    }
}
