using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Domain.Models;

public class Client
{
    public long ClientId { get; set; }
    public long UserId { get; set; }
    public long TelegramChatId { get; set; }
    public string Nickname { get; set; }
    public ClientStatus Status { get; set; }
    public bool IsPremium { get; set; }
}