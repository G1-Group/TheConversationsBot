using System.Runtime.InteropServices.JavaScript;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TheConversationsBot.TelegramBot;

public class TelegramBot
{
    private TelegramBotClient bot;
    private string token = "6171119365:AAHuWwdkJU2B60_V9wd0hs5G3hanYCKXaas";

    public List<Func<ITelegramBotClient, Update, CancellationToken, Task>> _updateHandlers ;

    public TelegramBot()
    {
        _updateHandlers = new List<Func<ITelegramBotClient, Update, CancellationToken, Task>>();
    }
    public void Start()
    {
        bot = new TelegramBotClient(token);
        bot.StartReceiving(Update, Error);
    }

    public async Task Update(ITelegramBotClient bota, Update update, CancellationToken arg3)
    {
    }

    public Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
    {
        throw new NotImplementedException();
    }
}