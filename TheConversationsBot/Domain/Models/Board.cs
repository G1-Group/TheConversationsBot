namespace TheConversationsBot.Domain.Models;

public class Board
{
 
    public long BoardId  { get; set; }
    public string Nickname { get; set; }
    public long OwnerId { get; set; }
}