using Microsoft.Data.SqlClient;

SqlConnection connection = new SqlConnection("Server=.;Database=MinionsDB;Integrated security=true");
connection.Open();

using (connection)
{
    List<string> townsToUpdate = GetTownsToUpdate(connection);
    List<string> updatedTowns = UpdateTowns(connection, townsToUpdate);
    PrintUpdatedTowns(updatedTowns);
}

static void PrintUpdatedTowns(List<string> updatedTowns)
{
    if (updatedTowns.Count > 0)
    {
        Console.WriteLine($"{updatedTowns.Count} town names were affected.");
        Console.WriteLine($"[{string.Join(", ", updatedTowns)}]");
    }
    else
        Console.WriteLine("No town names were affected.");
}

static List<string> UpdateTowns(SqlConnection connection, List<string> townsToUpdate)
{
    List<string> updatedTowns = new List<string>();
    foreach (string townName in townsToUpdate)
    {
        SqlCommand updateTownCmd = GetSqlCommand(connection, "UpdateTown", "@name", townName);
        int affectedRows = (int)updateTownCmd.ExecuteNonQuery();
        if (affectedRows == 1)
            updatedTowns.Add(townName.ToUpper());
    }
    return updatedTowns;
}

static List<string> GetTownsToUpdate(SqlConnection connection)
{
    Console.Write("Enter country name: ");
    string countryName = Console.ReadLine();

    SqlCommand getTownsCmd = GetSqlCommand(connection, "FindTowns", "@countryName", countryName);
    SqlDataReader reader = getTownsCmd.ExecuteReader();
    List<string> townsToUpdate = new List<string>();

    using (reader)
    {
        while (reader.Read())
        {
            string townName = (string)reader["Name"];
            if (townName != townName.ToUpper())
                townsToUpdate.Add(townName);
        }
    }
    return townsToUpdate;
}

static SqlCommand GetSqlCommand(SqlConnection connection, string fileName, string paramName, string paramValue)
{
    string query = File.ReadAllText($@"../../{fileName}.sql");
    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.AddWithValue(paramName, paramValue);
    return command;
}