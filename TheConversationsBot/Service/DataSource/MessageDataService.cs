using TheConversationsBot.Domain.Models;
using TheConversationsBot.Configurations;


namespace TheConversationsBot.Service.DataSource;

public class MessageDataService:DataServiceBase<Message>,IMessageDataService
{
    public MessageDataService(DataContext context) : base(context)
    {
    }
}