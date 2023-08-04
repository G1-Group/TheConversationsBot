namespace TheConversationsBot.Service.Interface;

public partial class SQLService : DataProvider
{
    public SQLService(string connectionString) : base(connectionString)
    {
        
    }
}