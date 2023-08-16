using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheConversationsBot.Domain.Models;

[Table("users")]
public class User : ModelBase
{
    [Column("phone_number")] public string PhoneNumber { get; set; }
    [Column("password")] public string Password { get; set; }
    [Column("telegram_client_id")] public long TelegramClientId { get; set; }
    
    [NotMapped] public Client Client { get; set; }
}