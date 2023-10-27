using Microsoft.Data.SqlClient;

SqlConnection connection = new SqlConnection("Server=.;Integrated Security=true");
connection.Open();

using (connection)
{
    CreateDB(connection);
    CreateDbTables(connection);
}

static void CreateDbTables(SqlConnection connection)
{
    string query = File.ReadAllText(@"../../CreateMinionsDbTables.sql");
    SqlCommand command = new SqlCommand(query, connection);
    Console.WriteLine("Created DB tables. Rows affected {0}.", command.ExecuteNonQuery());
}

static void CreateDB(SqlConnection connection)
{
    string query = "CREATE DATABASE MinionsDB";
    SqlCommand command = new SqlCommand(query, connection);
    command.ExecuteNonQuery();
    Console.WriteLine("Created database MinionsDB.");
}