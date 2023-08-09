using System.ComponentModel;
using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Domain;

public class ChatModel
{
        [Description("created_date")]
        public DateTime CreatedDate { get; set; }
        [Description("from_id")]
        public long FromId { get; set; }
        [Description("to_id")]
        public long ToId { get; set; }
        [Description("state")]
        public ChatState State { get; set; }
        [Description("chat_id")]
        public long Id { get; set; }
}