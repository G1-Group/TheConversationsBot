using Telegram.Bot;
using TheConversationsBot.TelegramBot;

namespace TheConversationsBot.TelegramBot;

public abstract class ControllerBase
{
    private TelegramBotClient BotClient;

    protected ControllerBase(TelegramBotClient botClient)
    {
        BotClient = botClient;
    }
    
    public abstract void HandleAction(ControllerContext context);
}