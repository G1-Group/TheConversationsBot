
using Npgsql;
using TheConversationsBot.Service.Interface;

class Program
{
    static void Main(string[] args)
    {
        NpgsqlConnectionStringBuilder connectionStringBuilder = new NpgsqlConnectionStringBuilder();
        connectionStringBuilder.Database = "postgres";
        connectionStringBuilder.Host = "localhost";
        connectionStringBuilder.Port = 5432;
        connectionStringBuilder.Username = "postgres";
        connectionStringBuilder.Password = "20431217";

        Console.WriteLine(connectionStringBuilder.ConnectionString);
        
        DataProvider dataProvider = new DataProvider(connectionStringBuilder.ConnectionString);
        var result = dataProvider.ExecuteWithResult("SELECT 345;", null).Result;
        result.Read();
        Console.WriteLine("Db Result: ", result.GetInt32(0));

    }
}