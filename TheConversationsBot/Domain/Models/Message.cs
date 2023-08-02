using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Domain.Models;

public class Message
{
    //from_id long
    //message object
      //  chat_id long
       // type message_type
       // board_id long
       public long FromId { get; set; }
       public object Messages { get; set; }
       public long ChatId { get; set; }
       public MessageType Type { get; set; }
       public long BoardId { get; set; }
}