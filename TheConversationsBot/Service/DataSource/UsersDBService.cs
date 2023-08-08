namespace TheConversationsBot.Service.DataSource;

public class UsersDBService : DataProvider,DBServiceBase
{
    public UsersDBService(string connectionString) : base(connectionString)
    {
    }

    public Task Insert<T>(T model)
    {
        throw new NotImplementedException();
    }

    public Task Insert<T>(List<T> models)
    {
        throw new NotImplementedException();
    }

    public Task Delete<T>(T model)
    {
        throw new NotImplementedException();
    }

    public Task Delete<T>(List<T> models)
    {
        throw new NotImplementedException();
    }

    public Task Updete<T>(T model)
    {
        throw new NotImplementedException();
    }

    public Task Updete<T>(List<T> models)
    {
        throw new NotImplementedException();
    }

    public Task Read<T>(T model)
    {
        throw new NotImplementedException();
    }

    public Task Read<T>(List<T> models)
    {
        throw new NotImplementedException();
    }
}