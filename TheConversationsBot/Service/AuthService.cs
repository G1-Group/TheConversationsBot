using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class AuthService : IAuthService
{
    public async Task<Client> Registration(User user)
    {
        ClientService clientService = new ClientService();
        Client client = await clientService.Create(user);
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