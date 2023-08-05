using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class AuthService : IAuthService
{
    public Task<Client> UserID(User user)
    {
        throw new NotImplementedException();
    }


    public async Task<User> Login(string phoneNumber, string password)
    {
        User user = new User()
        {
            PhoneNumber = phoneNumber,
            Password = password
        };
        return user;
    }
}