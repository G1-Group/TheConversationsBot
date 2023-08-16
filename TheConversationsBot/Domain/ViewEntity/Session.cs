using System.ComponentModel.DataAnnotations.Schema;

namespace TheConversationsBot.Domain.Models;

[NotMapped]
public class Session:ModelBase
{
    public string Action { get; set; }
    public string Controller { get; set; }
    public long TelegramChatId { get; set; }

    public Session()
    {
        RegistianView = new RegistianView();
        ConversationView = new ConversationView();
        BoardView = new BoardView();
        LoginView = new LoginView();
    }
    public LoginView LoginView { get; set; }
    public RegistianView RegistianView { get; set; }
    public BoardView BoardView { get; set; }
    public ConversationView ConversationView { get; set; }
    
}