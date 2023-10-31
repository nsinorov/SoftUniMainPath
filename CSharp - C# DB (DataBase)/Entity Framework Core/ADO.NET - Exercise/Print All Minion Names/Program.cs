using Microsoft.Data.SqlClient;

SqlConnection connection = new SqlConnection("Server=.;Database=MinionsDB;Integrated security=true");
connection.Open();

using (connection)
{
    SqlCommand findMinionsCmd = new SqlCommand("SELECT Name FROM Minions ORDER BY Id", connection);
    SqlDataReader reader = findMinionsCmd.ExecuteReader();
    List<string> names = new List<string>();

    using (reader)
    {
        while (reader.Read())
        { 
            names.Add((string)reader["Name"]); 
        }
    }
    for (int i = 0; i < names.Count / 2; i++)
    {
        Console.WriteLine(names[i]);
        Console.WriteLine(names[names.Count - 1 - i]);
    }
    if (names.Count % 2 == 1)
    {
        Console.WriteLine(names[names.Count / 2]);
    }
}