using System.ComponentModel;
using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Domain.Models;

public class Message
{
    [Description("id")] public long Id { get; set; }
    [Description("from_id")] public long FromId { get; set; }
    [Description("message")] public object Messages { get; set; }
    [Description("chat_id")] public long ChatId { get; set; }
    [Description("type")] public MessageType Type { get; set; }
    [Description("board_id")] public long BoardId { get; set; }
}