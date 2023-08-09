using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public class AuthService:IAuthService
{
    public Task<User> Login(string phoneNumber, string password)
    {
        throw new NotImplementedException();
    }

    public Task<Client> Registration(User user)
    {
        throw new NotImplementedException();
    }
}