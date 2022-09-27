using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            int snowBalls = int.Parse(Console.ReadLine());

            BigInteger snowBallValue = 0;
            BigInteger snowBallSnow = 0;
            BigInteger snowBalTime = 0;
            int snowBallQuality = 0;
            BigInteger bestSnowBall = int.MinValue;
            string bestSnowBallFormula = "";

            for (int i = 0; i < snowBalls; i++)
            {
                snowBallSnow = BigInteger.Parse(Console.ReadLine());
                snowBalTime = BigInteger.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowValue = snowBallSnow / snowBalTime;
                snowBallValue = BigInteger.Pow(currentSnowValue, snowBallQuality);

                if(snowBallValue > bestSnowBall)
                {
                    bestSnowBall = snowBallValue;
                    bestSnowBallFormula = $"{snowBallSnow} : {snowBalTime} = {snowBallValue} ({snowBallQuality})";
                }

            }
            Console.WriteLine(bestSnowBallFormula);
        }
    }
}
