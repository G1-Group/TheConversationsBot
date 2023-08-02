namespace TheConversationsBot.Domain.Models;

public class User
{
    public long Id { get; set; }
    public long TelegramClientId { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
}