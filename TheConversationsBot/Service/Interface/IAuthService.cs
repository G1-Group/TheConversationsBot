using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public interface IAuthService
{
    public Task<Client> UserID(User user);
}