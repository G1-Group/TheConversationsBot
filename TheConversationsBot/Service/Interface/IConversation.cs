using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public interface IConversation
{
    Task LastConversationAsync(long TelegramClientId);
    Task<bool> CheckConversationLimit(long TelegramClientId);
    Task<bool> CheckAviableClient(List<Client> clients);
}