using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsNumbers = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int tournamentPoints = 0;
            int win = 0;

            for (int i = 0; i < tournamentsNumbers; i++)
            {
                string currentTournament = Console.ReadLine();

                if (currentTournament == "W")
                {
                    tournamentPoints += 2000;
                    win++;
                }
                else if (currentTournament == "F")
                {
                    tournamentPoints += 1200;
                }
                else if (currentTournament == "SF")
                {
                    tournamentPoints += 720;
                }
            }

            Console.WriteLine($"Final points: {points + tournamentPoints}");
            Console.WriteLine($"Average points: {tournamentPoints / tournamentsNumbers}");
            Console.WriteLine($"{100.0 * win / tournamentsNumbers:f2}%");
        }
    }
}