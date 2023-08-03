
using System.Reflection.Emit;

using TheConversationsBot.Domain.Models;


namespace TheConversationsBot.Service.Interface;

public interface IConversation
{

    Task StartNewConversationAsync(long TelegramChatID);

    Task LastConversationAsync(long TelegramClientId);
    Task<bool> CheckConversationLimit(long TelegramClientId);

    Task CreateRoom((long,long)RoomForCouple);



    Task<bool> CheckAviableClient(List<Client> clients);


    Task AddClientsToRoom(long TelegramClientId);
}





