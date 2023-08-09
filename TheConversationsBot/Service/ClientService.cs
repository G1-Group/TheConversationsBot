using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.DataSource;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class ClientService:IClientService
{
    public Task<Client> CreateClient(Client data)
    {
        throw new NotImplementedException();
    }

    public Task<Client> RemoveClient(Client data)
    {
        throw new NotImplementedException();
    }

    public Task<Client> FindClient(Client data)
    {
        throw new NotImplementedException();
    }

    public Task<Client> UpdateClient(Client data)
    {
        throw new NotImplementedException();
    }
}