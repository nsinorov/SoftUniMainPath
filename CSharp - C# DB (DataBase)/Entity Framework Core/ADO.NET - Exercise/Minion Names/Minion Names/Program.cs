using Microsoft.Data.SqlClient;
using Minion_Names;

internal class Program
{
    private static void Main(string[] args)
    {

        const string connectionString = "Server=DESKTOP-NGVD83T\\SQLEXPRESS;Database=MinionsDB;Integrated Security=True;TrustServerCertificate=True";


        using SqlConnection sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();

        using SqlCommand getVillainsCommand = new SqlCommand(SQLQueries.GetVillainsWithNumberOfMinions, sqlConnection);

        using SqlDataReader sqlDataReader = getVillainsCommand.ExecuteReader();

        while (sqlDataReader.Read())
        {
            Console.WriteLine($"{sqlDataReader["Name"]} - {sqlDataReader["TotalMinions"]}");
        }


    }
}