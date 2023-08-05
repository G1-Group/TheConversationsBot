using System.ComponentModel;
using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Domain.Models;

public class Client
{
    [Description("client_id")] public long ClientId { get; set; }
    [Description("user_id")] public long UserId { get; set; }

    [Description("telegram_chat_id")] public long TelegramChatId { get; set; }
    [Description("nickname")] public string Nickname { get; set; }
    [Description("status")] public ClientStatus Status { get; set; }
    [Description("is_premium")] public bool IsPremium { get; set; }
}