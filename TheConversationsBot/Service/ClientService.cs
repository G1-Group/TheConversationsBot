using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.DataSource;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class ClientService:IClientService
{
    private ClientDBService _clientDbService;

    public ClientService()
    {
            
    }

    public Task<Client> CreateData(Client data)
    {
        throw new NotImplementedException();
    }

    public Task<Client> UpdateData(long Id, Client data)
    {
        throw new NotImplementedException();
    }

    public Task<List<Client>> GetAllData()
    {
        throw new NotImplementedException();
    }

    public Task<Client> FindByIdData(long Id)
    {
        throw new NotImplementedException();
    }

    public Task<Client> DeleteData(long Id)
    {
        throw new NotImplementedException();
    }

    public Task<Client> FindByUserId(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Client> FindByNickName(string nickName)
    {
        throw new NotImplementedException();
    }
}