using System.Runtime.InteropServices.JavaScript;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TheConversationsBot.TelegramBot;

public class TelegramBot
{
    private TelegramBotClient bot;
    private string token = "6171119365:AAHuWwdkJU2B60_V9wd0hs5G3hanYCKXaas";

    public delegate Task UpdateHandlerDelegate
    (ITelegramBotClient bot,
        Update update,
        CancellationToken cancellationToken);

    List<UpdateHandlerDelegate> updateHandlers = new List<UpdateHandlerDelegate>();

    public void Start()
    {
        bot = new TelegramBotClient(token);
        bot.StartReceiving(Update, Error);
    }

    private async Task Update(ITelegramBotClient bota, Update update, CancellationToken arg3)
    {
    }

    private Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
    {
        throw new NotImplementedException();
    }
}