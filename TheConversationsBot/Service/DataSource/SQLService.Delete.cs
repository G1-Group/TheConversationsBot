using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public partial class SQLService
{
    public async Task DeleteUserAsync(User user)
    {
    }

    public async Task DeleteClientAsync(Client client)
    {
    }

    public async Task DeleteMessageAsync(Message message)
    {
    }

    public async Task DeleteAnonymChatAsync(Client client)
    {
    }

    private async Task DeleteBoardAsync(Client client)
    {
    }
}