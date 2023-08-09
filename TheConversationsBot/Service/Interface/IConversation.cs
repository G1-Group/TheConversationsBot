using TheConversationsBot.Domain;

namespace TheConversationsBot.Service.Interface;

public interface IConversation
{
    public int CreateConversation(ChatModel chat);
    public ChatModel StopConversation(long chatId);
    public ChatModel  GetLastConversation(long chatId);

    public ChatModel UpdateConversation(ChatModel chat);
    public ChatModel GetConversation(long chatId);

    public List<ChatModel> GetAllConversation();

}