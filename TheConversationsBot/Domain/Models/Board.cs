using System.ComponentModel;

namespace TheConversationsBot.Domain.Models;

public class Board
{
    [Description("id")] public long BoardId { get; set; }
    [Description("nickname")] public string Nickname { get; set; }
    [Description("owner_id")] public long OwnerId { get; set; }
}