namespace TheConversationsBot.Service.Interface;

public interface IConversation
{

    Task StartNewConversationAsync(long TelegramChatID);

    Task LastConversationAsync(long TelegramClientId);
    Task<bool> CheckConversationLimit(long TelegramClientId);

}