using Microsoft.EntityFrameworkCore;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public class ConversationDataService : DataServiceBase<Conversation>,IConversationDataService
{
    public ConversationDataService(DbContext context) : base(context)
    {
    }
}