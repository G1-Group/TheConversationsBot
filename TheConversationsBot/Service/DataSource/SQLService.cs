namespace TheConversationsBot.Service.DataSource;

public partial class SQLService : DataProvider
{
    public SQLService(string connectionString) : base(connectionString)
    {
        
    }
}