using P01.Stream_Progress.Models;
using P01.Stream_Progress.Streams;
using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            var file = new File("File name", 1234, 123);
            var fileProcessInfo = new StreamProgressInfo(file);
            Console.WriteLine(fileProcessInfo.CalculateCurrentPercent());

            var music = new Music("Singer", "Album", 123456, 12349);
            var musicProcessInfo = new StreamProgressInfo(music);
            Console.WriteLine(musicProcessInfo.CalculateCurrentPercent());
        }
    }
}
