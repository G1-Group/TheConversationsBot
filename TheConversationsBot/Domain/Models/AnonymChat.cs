namespace TheConversationsBot.Domain.Enums;

public class AnonymChat
{
    public long Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public long FromId { get; set; }
    public long ToId { get; set; }
    public ChatState State  { get; set; }
}
