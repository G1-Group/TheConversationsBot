using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class AuthService : IAuthService
{
    public async Task<Client> Registration(User user)
    {
        Client client = new Client()
        {
            UserId = user.Id,
            TelegramChatId = user.TelegramClientId
        };
        return client;
    }
}