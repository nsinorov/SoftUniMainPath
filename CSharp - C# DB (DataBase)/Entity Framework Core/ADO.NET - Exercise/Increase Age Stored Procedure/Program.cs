using Microsoft.Data.SqlClient;

SqlConnection connection = new SqlConnection("Server=.;Database=MinionsDB;Integrated security=true");
connection.Open();

using (connection)
{
    Console.Write("Enter minion ID: ");
    int minionId = int.Parse(Console.ReadLine());

    IncreaseAgeWithProc(connection, minionId);
    PrintMinionsNameAge(connection, minionId);
}

static void PrintMinionsNameAge(SqlConnection connection, int minionId)
{
    string query = @"SELECT Name, Age FROM Minions WHERE Id = @id";
    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.AddWithValue("@id", minionId);
    SqlDataReader reader = command.ExecuteReader();

    using (reader)
    {
        while (reader.Read())
        {
            string name = (string)reader["Name"];
            int age = (int)reader["Age"];
            Console.WriteLine($"{name} {age}");
        }
    }
}

static void IncreaseAgeWithProc(SqlConnection connection, int minionId)
{
    string execProc = @"EXEC usp_GetOlder @id";
    SqlCommand command = new SqlCommand(execProc, connection);
    command.Parameters.AddWithValue("@id", minionId);
    command.ExecuteNonQuery();
}