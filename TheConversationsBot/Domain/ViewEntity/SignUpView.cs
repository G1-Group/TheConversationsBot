namespace TheConversationsBot.Domain.Models;

public class SignUpView:LoginView
{
    public string NickName { get; set; }
    public string UserName { get; set; }
    public long TelegramChatId { get; set; }
}