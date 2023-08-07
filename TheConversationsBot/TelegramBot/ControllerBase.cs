using Controller;
using Telegram.Bot;
using TheConversationsBot.TelegramBot;

namespace TheConversationsBot.TelegramBot;

public abstract class ControllerBase
{
    protected ITelegramBotClient _botClient;

    protected ControllerBase(ITelegramBotClient botClient)
    {
        _botClient = botClient;
    }
    
    public abstract void HandleAction(ControllerContext context);
}