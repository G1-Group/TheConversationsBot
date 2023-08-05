using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class AuthService: IAuthService
{
    public Task<Client> UserID(User user)
    {
        throw new NotImplementedException();
    }
}