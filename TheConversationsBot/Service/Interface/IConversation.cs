namespace TheConversationsBot.Service.Interface;

public interface IConversation
{
    Task LastConversationAsync(long TelegramClientId);
}