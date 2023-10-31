using Microsoft.Data.SqlClient;
using System.Globalization;

SqlConnection connection = new SqlConnection("Server=.;Database=MinionsDB;Integrated security=true");
connection.Open();

using (connection)
{
    UpdateMinionsNameAge(connection);
    PrintMinions(connection);
}


static void PrintMinions(SqlConnection connection)
{
    string getNameAgeQuery = "SELECT Name, Age FROM Minions";
    SqlCommand getNameAgeCmd = new SqlCommand(getNameAgeQuery, connection);
    SqlDataReader reader = getNameAgeCmd.ExecuteReader();
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

static void UpdateMinionsNameAge(SqlConnection connection)
{
    Console.Write("Enter minion IDs separated by space: ");
    int[] ids = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    for (int i = 0; i < ids.Length; i++)
    {
        SqlCommand getMinionCmd = GetSqlCommand(connection, "FindMinionName", ids[i]);
        string minionName = (string)getMinionCmd.ExecuteScalar();
        if (minionName != null)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            minionName = textInfo.ToTitleCase(minionName);

            SqlCommand updateMinionCmd = GetSqlCommand(connection, "UpdateMinion", ids[i]);
            updateMinionCmd.Parameters.AddWithValue("@name", minionName);
            updateMinionCmd.ExecuteNonQuery();
        }
    }
}

static SqlCommand GetSqlCommand(SqlConnection connection, string fileName, int id)
{
    string query = File.ReadAllText($@"../../{fileName}.sql");
    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.AddWithValue("@Id", id);
    return command;
}