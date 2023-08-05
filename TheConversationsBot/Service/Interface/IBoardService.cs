using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public interface IBoardService
{
    Task<Board> CreateBoardAsync(Client client, string nickname);
    Task<Message> SendMessage(long boardId, string message);
}