namespace TheConversationsBot.Domain.Models;

public class Board
{
   // board_id long
       // nickname string
       // owner_id long
    public long BoardId  { get; set; }
    public string Nickname { get; set; }
    public long OwnerId { get; set; }
}