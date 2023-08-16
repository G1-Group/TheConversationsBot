using TheConversationsBot.Domain.Models;
using TheConversationsBot.TelegramBot.Controllers;

namespace TheConversationsBot.TelegramBot.Managers;

public class SessionManager:ISessionManager<Session>
{
    public async Task<Session> GetSessionByChatId(long chatId)
    {
        throw new NotImplementedException();
    }
}