using Telegram.Bot.Types;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.TelegramBot;

public class Context
{
    public Session Session { get; set; }
    public Update Update { get; set; }
}