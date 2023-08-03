namespace TheConversationsBot.Service.Interface;

public interface IConversation
{
    Task StartNewConversationAsync(long TelegramChatID);
}