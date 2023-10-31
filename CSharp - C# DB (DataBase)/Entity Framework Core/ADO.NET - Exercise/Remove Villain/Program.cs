using Microsoft.Data.SqlClient;

SqlConnection connection = new SqlConnection("Server=.;Database=MinionsDB;Integrated security=true");
connection.Open();

using (connection)
{
    Console.Write("Enter villain ID: ");
    int villainId = int.Parse(Console.ReadLine());

    SqlCommand getVillainNameCmd = GetSqlCommand(connection, "FindVillainName", villainId);
    string villainName = (string)getVillainNameCmd.ExecuteScalar();
    if (villainName == null)
    {
        Console.WriteLine("No such villain was found"); return;
    }

    SqlCommand deleteMinionsVillainsCmd = GetSqlCommand(connection, "DeleteMinionsVillains", villainId);
    int realeasedMinions = (int)deleteMinionsVillainsCmd.ExecuteNonQuery();

    SqlCommand deleteVillainCmd = GetSqlCommand(connection, "DeleteVillain", villainId);
    int affectedRows = (int)deleteVillainCmd.ExecuteNonQuery();

    if (affectedRows != 0)
        Console.WriteLine($"{villainName} was deleted");
    Console.WriteLine($"{realeasedMinions} minions released");
}

static SqlCommand GetSqlCommand(SqlConnection connection, string fileName, int villainId)
{
    string query = File.ReadAllText($@"../../{fileName}.sql");
    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.AddWithValue("@villainId", villainId);
    return command;
}