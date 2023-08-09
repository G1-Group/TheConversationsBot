using TheConversationsBot.Domain;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class ConversationService:IConversation
{
    public int CreateConversation(ChatModel chat)
    {
        throw new NotImplementedException();
    }

    public ChatModel StopConversation(long chatId)
    {
        throw new NotImplementedException();
    }

    public ChatModel GetLastConversation(long chatId)
    {
        throw new NotImplementedException();
    }

    public ChatModel UpdateConversation(ChatModel chat)
    {
        throw new NotImplementedException();
    }

    public ChatModel GetConversation(long chatId)
    {
        throw new NotImplementedException();
    }

    public List<ChatModel> GetAllConversation()
    {
        throw new NotImplementedException();
    }
}