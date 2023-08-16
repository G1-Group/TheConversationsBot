using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheConversationsBot.Domain.Models;

[Table("logs")]
public class LogView : ModelBase
{
    [Column("Datetime")] public DateTime Date { get; set; }
    [Column("from_id")] public long FromId { get; set; }
    [Column("to_id")] public long ToId { get; set; }
    [Column("update_message")] public Telegram.Bot.Types.Message UpdateMessage { get; set; }
    [Column("exception_message")] public string ExceptionMessage { get; set; }
}