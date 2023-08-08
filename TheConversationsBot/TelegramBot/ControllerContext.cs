using Telegram.Bot.Types;
using TheConversationsBot.Domain.Models;
using TheConversationsBot.TelegramBot;

namespace Controller;

public class ControllerContext
{
    public Update Update { get; set; }
    public Session Session { get; set; }
}