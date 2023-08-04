using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public partial class SQLService
{
    public async Task<List<User>> GetUsersAsync()
    {
        return null;
    }

    public async Task<User> GetUserAsync(long UserId)
    {
        return null;
    }
}