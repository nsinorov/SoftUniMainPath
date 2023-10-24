using Microsoft.Data.SqlClient;


string connectionString = "Server=.;Database=...;User Id=...;Password=...;...trusted connections";

using SqlConnection sqlConnection = new SqlConnection(connectionString);

await sqlConnection.OpenAsync();

string username = Console.ReadLine();
string password = Console.ReadLine();
string query = $"SELECT Id FROM Users WHERE Username = '{username}' AND Password = '{password}'";

 SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

int? id = (int?)(await sqlCommand.ExecuteScalarAsync());

if( id != null && id > 0)
{
    Console.WriteLine($"You are user with Id: {id}");
}
else
{
    Console.WriteLine("Invalid username or password");
}

// The above code will work and will be vulnerable to SQL Injections ->
// ' OR 1=1 -- 
// fewfgewrfweqfeq
// You are user with Id: 1


// The below code will show how to protect from SQL Injections with just adding 2-3 additional lines. 

string connectionString = "Server=.;Database=...;User Id=...;Password=...;...trusted connections";

using SqlConnection sqlConnection = new SqlConnection(connectionString);

await sqlConnection.OpenAsync();

string username = Console.ReadLine();
string password = Console.ReadLine();
string query = $"SELECT Id FROM Users WHERE Username = @usernameParam AND Password = @passwordParam"; // Also here the username and password are set like this

using SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
sqlCommand.Parameters.AddWithValue("@usernameParam", username);    // These are the additional lines.
sqlCommand.Parameters.AddWithValue("@passwordParam", password);    // These are the additional lines.

int? id = (int?)(await sqlCommand.ExecuteScalarAsync());

if (id != null && id > 0)
{
    Console.WriteLine($"You are user with Id: {id}");
}
else
{
    Console.WriteLine("Invalid username or password");
}





// Evil hacker, code is below. It creates a user in the database: 

string connectionString = "Server=.;Database=...;User Id=...;Password=...;...trusted connections";

using SqlConnection sqlConnection = new SqlConnection(connectionString);

await sqlConnection.OpenAsync();

string username = Console.ReadLine();
string password = Console.ReadLine();

string query = $"SELECT Id FROM Users WHERE Username = '{username}' AND Password = '{password}'"; 

using SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
sqlCommand.Parameters.AddWithValue("@usernameParam", username);
sqlCommand.Parameters.AddWithValue("@passwordParam", password); 

int? id = (int?)(await sqlCommand.ExecuteScalarAsync());

if (id != null && id > 0)
{
    Console.WriteLine($"You are user with Id: {id}");
}
else
{
    Console.WriteLine("Invalid username or password");
}

// Write in the console the following: 
// '; INSERT INTO Users (Username, Password) VALUES ('EvilHacker', '123') --

// The output will be that the user is created with username: EvilHacker and Password: 123 in the Database :)