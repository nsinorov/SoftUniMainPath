using Microsoft.Data.SqlClient;

string connectionString = "Server=.;Database=;User Id=;Password=";

using (SqlConnection sqlConnection = new SqlConnection(connectionString))
{
    sqlConnection.Open();

    string query = "SELECT COUNT(*) FROM Employees";

    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
    {
        int count = (int)sqlCommand.ExecuteScalar();

        Console.WriteLine($"Employees count: {count}");
    }
}

// Препоръчително е да използваме Async, по-добре е за сървърите