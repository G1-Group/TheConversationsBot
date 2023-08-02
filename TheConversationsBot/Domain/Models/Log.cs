namespace TheConversationsBot.Domain.Models;

public class Log
{
    public DateTime Date { get; set; }
    public long FromId { get; set; }
    public long ToId { get; set; }
    public string Action { get; set; }
    public string ExceptionMessage { get; set; }
}