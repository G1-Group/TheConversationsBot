using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public class UsersIdbService : DataProvider,IDBServiceBase<User>
{
    public UsersIdbService(string connectionString) : base(connectionString)
    {
    }

    public Task Insert(User model)
    {
        throw new NotImplementedException();
    }

    public Task Insert(List<User> models)
    {
        throw new NotImplementedException();
    }

    public Task Delete(User model)
    {
        throw new NotImplementedException();
    }

    public Task Delete(List<User> models)
    {
        throw new NotImplementedException();
    }

    public Task Updete(User model)
    {
        throw new NotImplementedException();
    }

    public Task Updete(List<User> models)
    {
        throw new NotImplementedException();
    }

    public Task Read(User model)
    {
        throw new NotImplementedException();
    }

    public Task Read(List<User> models)
    {
        throw new NotImplementedException();
    }
}