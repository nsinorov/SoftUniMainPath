namespace MusicHub;

using System;
using System.Text;
using Data;
using Initializer;
using MusicHub.Data.Models;

public class StartUp
{
    public static void Main()
    {
        MusicHubDbContext context =
            new MusicHubDbContext();

        DbInitializer.ResetDatabase(context);

        string output = string.Empty;

        //Test 02.Export Albums Info
        //output = ExportAlbumsInfo(context, 9);

        //Test 03.Export Songs Above Duration
        output = ExportSongsAboveDuration(context, 4);

        Console.WriteLine(output);
    }

    public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
    {
        //Finding the Albums
        var albums = context
             .Producers
             .First(p => p.Id == producerId)
             .Albums
            .Select(a => new
            {
                AlbumName = a.Name,
                ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy"),
                ProducerName = a.Producer.Name,
                Songs = a.Songs.Select(s => new
                {
                    SongName = s.Name,
                    Price = s.Price,
                    Writer = s.Writer.Name
                })
                .OrderByDescending(s => s.SongName)
                .ThenBy(s => s.Writer),
                AlbumPrice = a.Price
            })
            .OrderByDescending(a => a.AlbumPrice);


        //Output
        StringBuilder sb = new StringBuilder();

        foreach (var album in albums)
        {
            sb.AppendLine($"-AlbumName: {album.AlbumName}");
            sb.AppendLine($"-ReleaseDate: {album.ReleaseDate}");
            sb.AppendLine($"-ProducerName: {album.ProducerName}");
            sb.AppendLine($"-Songs:");

            if (album.Songs.Any())
            {
                int songsCounter = 0;
                foreach (var song in album.Songs)
                {
                    songsCounter++;
                    sb.AppendLine($"---#{songsCounter}");
                    sb.AppendLine($"---SongName: {song.SongName}");
                    sb.AppendLine($"---Price: {song.Price:f2}");
                    sb.AppendLine($"---Writer: {song.Writer}");
                }
            }
            sb.AppendLine($"-AlbumPrice: {album.AlbumPrice:f2}");
        }
        return sb.ToString().TrimEnd();
    }

    public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
    {
        //Finding the Songs
        var songs = context.Songs
            .AsEnumerable()
            .Where(s => s.Duration.TotalSeconds > duration)
            .Select(s => new
            {
                SongName = s.Name,
                WriterName = s.Writer.Name,
                Performers = s.SongPerformers
                    .Select(p => new
                    {
                       PerformerFullName = $"{p.Performer.FirstName} {p.Performer.LastName}"
                    })
                    .OrderBy(p => p.PerformerFullName)
                    .ToList(),
                AlbumProducer = s.Album.Producer.Name,
                Duration = s.Duration.ToString("c")
            })
            .OrderBy(s => s.SongName)
            .ThenBy(s => s.WriterName)
            .ToList();

        //Output
        int songsCounter = 0;
        StringBuilder sb = new StringBuilder();

        foreach (var song in songs)
        {
            songsCounter++;
            sb.AppendLine($"-Song #{songsCounter}");
            sb.AppendLine($"---SongName: {song.SongName}");
            sb.AppendLine($"---Writer: {song.WriterName}");

            if (song.Performers.Any())
            {
                foreach (var performer in song.Performers)
                {
                    sb.AppendLine($"---Performer: {performer.PerformerFullName}");
                }
            }

            sb.AppendLine($"---AlbumProducer: {song.AlbumProducer}");
            sb.AppendLine($"---Duration: {song.Duration}");
        }

        return sb.ToString().TrimEnd();
    }
}