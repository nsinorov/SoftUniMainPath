using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SoulMaster soulMaster = new("Dark", 100);

            Console.WriteLine(soulMaster.Username);
            Console.WriteLine(soulMaster.Level);
        }
    }
}