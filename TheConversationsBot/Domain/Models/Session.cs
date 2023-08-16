using System.ComponentModel.DataAnnotations.Schema;

namespace TheConversationsBot.Domain.Models;

[NotMapped]
public class Session
{
    public long Id { get; set; }
    public User User { get; set; }
    public string Action { get; set; }
    public string Controller { get; set; }
    public long ChatId { get; set; }
    public string UserLogin { get; set; }
    public string UserPassword { get; set; }
}