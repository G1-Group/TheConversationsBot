using Npgsql;
using Telegram.Bot.Types;

namespace TheConversationsBot.Service.Interface;

public interface IUserService:IDataSarvice<User>
{
    public Task<User> FindByPassword(string password);

    public Task<User> FindByPhoneNumber(string phoneNumber);
    
    public Task<User> FindByUserId(long userId);

    public User ReaderDataModel(NpgsqlDataReader reader);
}