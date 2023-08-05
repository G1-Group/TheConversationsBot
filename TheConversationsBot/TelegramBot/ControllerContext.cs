using Telegram.Bot.Types;
using TheConversationsBot.TelegramBot;

namespace Controller;

public class ControllerContext
{
    public Update Update { get; set; }
    public Session Session { get; set; }
}