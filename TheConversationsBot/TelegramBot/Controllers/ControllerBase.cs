using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TheConversationsBot.TelegramBot.Extensions;
using TheConversationsBot.TelegramBot.Managers;

namespace TheConversationsBot.TelegramBot.Controllers;

public abstract class ControllerBase
{
    protected readonly ITelegramBotClient _botClient = TelegramBot.BotClient;
    protected readonly ManagerController _managerController;
    protected Message message { get; set; }

    public ControllerBase(ManagerController managerController)
    {
        _managerController = managerController;
    }

    protected abstract Task Index(Context context);
    protected abstract Task HandleAction(Context context);
    protected abstract Task HandleUpdate(Context context);

    public async Task Handle(Context context)
    {
        SetUpdateMessage(context);
        string oldController = context.Session.Controller;
        await this.HandleUpdate(context);
        if (oldController != context.Session.Controller)
            await context.Forward(this._managerController);
        else
            await this.HandleAction(context);
    }

    private void SetUpdateMessage(Context context)
    {
        if (context.Update.Type is UpdateType.Message)
        {
            this.message = context.Update.Message;
            return;
        }

        this.message = null;
    }
}