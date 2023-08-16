using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Domain.Models;

[Table("clients")]
public class Client : ModelBase
{
    [Column("client_id")] public long ClientId { get; set; }
    [Column("user_id")] public long UserId { get; set; }
    [NotMapped] public User User { get; set; }
    [Column("user_name")] public string UserName { get; set; }
    [Column("nickname")] public string Nickname { get; set; }
    [Column("status")] public ClientStatus Status { get; set; }
    [Column("is_premium")] public bool IsPremium { get; set; }

    [NotMapped] public List<Message> Messages { get; set; }
    [NotMapped] public List<Board> Boards { get; set; }
    [NotMapped] public List<Conversation> ToConversations { get; set; }
    [NotMapped] public List<Conversation> FromConversations { get; set; }
}