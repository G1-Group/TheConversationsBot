using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.DataSource;

namespace TheConversationsBot.Service.Interface;

public interface IClientService
{
     Task<Client> UpdateClientNickname(long clientId, string nickname);
    Task<Client> UpdateClientUsername(long clientId, string username);
}