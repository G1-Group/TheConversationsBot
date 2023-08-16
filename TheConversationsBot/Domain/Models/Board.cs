using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheConversationsBot.Domain.Models;

[Table("boards")]
public class Board : ModelBase
{
    [Column("nickname")] public string NickName { get; set; }

    [Column("owner_id")] public long OwnerId { get; set; }

    [NotMapped] public Client Owner { get; set; }

    [Column("board_status")] public BoardStatus BoardStatus { get; set; }

    [NotMapped] public List<Message> Messages { get; set; }
}