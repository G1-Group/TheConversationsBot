using System.ComponentModel;

namespace TheConversationsBot.Domain.Models;

public class Log
{
    [Description("Datetime")] public DateTime Date { get; set; }
    [Description("from_id")] public long FromId { get; set; }
    [Description("to_id")] public long ToId { get; set; }
    [Description("actions")] public string Action { get; set; }
    [Description("exception_message")] public string ExceptionMessage { get; set; }
}