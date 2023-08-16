using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Domain.Models;

[Table("conversations")]
public class Conversation : ModelBase
{
    [Column("created_date")] public DateTime CreatedDate { get; set; }
    [Column("from_id")] public long FromId { get; set; }
    [NotMapped] public Client From { get; set; }
    [Column("to_id")] public long ToId { get; set; }
    [NotMapped] public Client To { get; set; }
    [Column("state")] public ChatState State { get; set; }
    [NotMapped] public List<Message> Messages { get; set; }
}