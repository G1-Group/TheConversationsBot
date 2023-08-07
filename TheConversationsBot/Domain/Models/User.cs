using System.ComponentModel;

namespace TheConversationsBot.Domain.Models;

public class User
{
    [Description("id")] public long Id { get; set; }
    [Description("telegram_client_id")] public long TelegramClientId { get; set; }
    [Description("phone_number")] public string PhoneNumber { get; set; }
    [Description("password")] public string Password { get; set; }
    public long UserId { get; set; }
}