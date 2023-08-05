using Telegram.Bot;

namespace TheConversationsBot.TelegramBot;

public class TelegramBot
{
    private string token = "";
    private TelegramBotClient botClient;

    public TelegramBot()
    {
        
    }

    private void Initialize()
    {
        this.botClient = new TelegramBotClient(token);

        SessionManager sessionManager = new SessionManager(null);

        ControllerManager controllerManager = new ControllerManager(botClient);

        this.botClient.StartReceiving(controllerManager);
    }

}