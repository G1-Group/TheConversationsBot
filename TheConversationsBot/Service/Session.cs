
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.TelegramBot;

//namespace TCBApp.Models;

public class Session
{
    public long Id { get; set; }
    public User User { get; set; }
    public string Action { get; set; }
    public string Controller { get; set; }
}