using System.Reflection.Emit;

namespace TheConversationsBot.Service.Interface;

public interface IConversation
{
    Task LastConversationAsync(long TelegramClientId);
    Task<bool> CheckConversationLimit(long TelegramClientId);
    Task CreateRoom((long,long)RoomForCouple);
}