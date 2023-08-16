using Microsoft.EntityFrameworkCore;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public class BoardDataService:DataServiceBase<Board>,IBoardDataService
{
    public BoardDataService(DbContext context) : base(context)
    {
    }
}