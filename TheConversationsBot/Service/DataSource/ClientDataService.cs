using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public class ClientDataService : DataServiceBase<Client>, IClientDataService
{
    public ClientDataService(DataContext context) : base(context)
    {
    }
}