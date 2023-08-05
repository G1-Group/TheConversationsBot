using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public interface IAuthService
{
    Task<User> Login(string phoneNumber, string password);
    public Task<Client> Registration(User user);
}