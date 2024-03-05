using System.Diagnostics;

//Using The Chronometer
var chronometer = new Chronometer();
string line;

while ((line = Console.ReadLine()) != "exit")
{
    if (line.ToLower() == "start")
    {
        Task.Run(() =>
        {
            chronometer.Start();
        });
    }
    else if (line.ToLower() == "stop")
    {
        chronometer.Stop();
    }
    else if (line.ToLower() == "lap")
    {
        Console.WriteLine(chronometer.Lap());
    }
    else if (line.ToLower() == "laps")
    {
        if (chronometer.Laps.Count == 0)
        {
            Console.WriteLine("You haven't done any laps yet.");
            continue;
        }

        Console.WriteLine("Laps: ");
        for (int i = 0; i < chronometer.Laps.Count; i++)
        {
            Console.WriteLine($"{i}. {chronometer.Laps[i]}");
        }
    }
    else if (line.ToLower() == "reset")
    {
        chronometer.Reset();
    }
    else if (line.ToLower() == "time")
    {
        Console.WriteLine(chronometer.GetTime);
    }
}
chronometer.Stop();

//Chronometer's Interface
public interface IChronometer
{
    string GetTime { get; }

    List<string> Laps { get; }

    void Start();
    void Stop();
    string Lap();
    void Reset();
}


//Chronometer's Class
public class Chronometer : IChronometer
{
    //Fields
    private Stopwatch stopwatch;
    private List<string> laps;

    //Constructor
    public Chronometer()
    {
        stopwatch = new Stopwatch();
        laps = new List<string>();
    }

    //Properties
    public string GetTime => stopwatch.Elapsed.ToString(@"mm\:ss\.ffff");

    public List<string> Laps => laps;


    //Methods
    public void Start()
    {
        stopwatch.Start();
    }

    public void Stop()
    {
        stopwatch.Stop();
    }

    public string Lap()
    {
        string result = GetTime;
        laps.Add(result);
        return result;
    }

    public void Reset()
    {
        stopwatch.Reset();
        laps.Clear();
    }
}
