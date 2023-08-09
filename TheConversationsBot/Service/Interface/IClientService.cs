using Npgsql;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public interface IClientService : IDataSarvice<Client>
{
    public Task<Client> FindByUserId(long id);
    public Task<Client> FindByNickName(string nickName);
}
