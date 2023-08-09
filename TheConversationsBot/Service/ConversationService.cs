using TheConversationsBot.Domain;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class ConversationService:IConversation
{
    private ConversationDataService Service { get; set; }

    public ConversationService()
    {
       
    }
    public int CreateConversation(ChatModel chat)
    {
        return Service.Insert(chat).Result;
    }

    public ChatModel StopConversation(long chatId)
    {
        return Service.StopConversation( chatId).Result;
    }

    public ChatModel GetLastConversation(long chatId)
    {
        throw new NotImplementedException();
    }

    public ChatModel UpdateConversation(ChatModel chat)
    {
        return Service.UpdateConversation(chat.Id, chat).Result;
    }

    public ChatModel GetConversation(long chatId)
    {
        return Service.GetById(chatId).Result;
    }

    public List<ChatModel> GetAllConversation()
    {
        return Service.GetAll().Result;
    }
}