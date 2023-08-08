using System.ComponentModel;
using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Domain.Models;

public class AnonymChat
{
    [Description("id")] public long Id { get; set; }
    [Description("create_date")] public DateTime CreatedDate { get; set; }
    [Description("from_id")] public long FromId { get; set; }
    [Description("to_id")] public long ToId { get; set; }
    [Description("state")] public ChatState State { get; set; }
}