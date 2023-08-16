using System.ComponentModel.DataAnnotations.Schema;

namespace TheConversationsBot.Domain.Models;

public class ModelBase
{
    [Column("id")]
    public long Id { get; set; }
}