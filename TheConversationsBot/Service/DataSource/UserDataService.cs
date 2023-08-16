using Microsoft.EntityFrameworkCore;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public class UserDataService:DataServiceBase<User>,IUserDataService
{
    public UserDataService(DataContext context) : base(context)
    {
    }
}