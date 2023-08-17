using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.DataSource;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class ClientService : IClientService
{
    private readonly IClientDataService _clientDataService;

    public ClientService(IClientDataService clientDataService)
    {
        _clientDataService = clientDataService;
    }
    public async Task<Client> UpdateClientNickname(long clientId, string nickname)
    {
        var client = await _clientDataService.GetByIdAsync(clientId);
        client.Nickname = nickname;

        return await _clientDataService.UpdateAsync(client);
    }

    public async Task<Client> UpdateClientUsername(long clientId, string username)
    {
        var client = await _clientDataService.GetByIdAsync(clientId);
        client.UserName = username;

        return await _clientDataService.UpdateAsync(client);
    }
}