using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class ClientService
{
    public async Task<Client> Create(User user)
    {
        Client client = new Client()
        {
            UserId = user.Id,
            TelegramChatId = user.TelegramClientId
        };
        return client;
    }

    public async Task Delete(Client client)
    {
        
    }

    public async Task Update(Client clientUpdate)
    {
        
    }

    public async Task<Client> ReadById(long clientId)
    {
        return new Client();
    }
}