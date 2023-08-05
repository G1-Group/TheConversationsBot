using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Domain.Models;

public class Message
{
       public long Id { get; set; }
       public long FromId { get; set; }
       public object Messages { get; set; }
       public long ChatId { get; set; }
       public MessageType Type { get; set; }
       public long BoardId { get; set; }
}