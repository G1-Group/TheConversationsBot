using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class AuthService : IAuthService
{
    public async Task<Client> Registration(User user)
    {
        Client client = new Client()
        {
            UserId = user.UserId,
            TelegramChatId = user.TelegramClientId
        };
        return client;
        
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