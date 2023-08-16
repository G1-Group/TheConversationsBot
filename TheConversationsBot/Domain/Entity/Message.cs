using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Domain.Models;

[Table("messages")]
public class Message : ModelBase
{
    [Column("from_id")] public long FromId { get; set; }
    [NotMapped] public Client Client { get; set; }
    [Column("content")] public Telegram.Bot.Types.Message Content { get; set; }
    [Column("conversation_id")] public long? ConversationId { get; set; }
    [NotMapped] public Conversation? Conversation { get; set; }
    [Column("board_id")] public long? BoardId { get; set; }
    [NotMapped] public Board? Board { get; set; }

    [Column("message_type")] public MessageType MessageType { get; set; }

    [Column("message_status")] public MessageStatus MessageStatus { get; set; }
}