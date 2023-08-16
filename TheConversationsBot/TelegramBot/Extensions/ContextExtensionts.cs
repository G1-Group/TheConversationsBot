using Telegram.Bot;
using Telegram.Bot.Requests;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TheConversationsBot.TelegramBot.Controllers;
using TheConversationsBot.TelegramBot.Managers;

namespace TheConversationsBot.TelegramBot.Extensions;

public static class ContextExtensionts
{
    public static async Task Forward(this Context context, ManagerController managerController)
    {
        ControllerBase controllerBase = await managerController.GetControllerBySessionData(context.Session);
        await controllerBase.Handle(context);
    }

    public static async Task SendTextMessage(this Context context, string text, IReplyMarkup? replyMarkup = null,
        ParseMode? parseMode = null)
    {
        await TelegramBot.BotClient.SendTextMessageAsync(context.Session.TelegramChatId, text, replyMarkup: replyMarkup,
            parseMode: parseMode);
    }
}