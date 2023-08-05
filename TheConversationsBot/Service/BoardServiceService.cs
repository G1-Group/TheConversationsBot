using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class BoardServiceService : IBoardService
{
    public async Task<Board> CreateBoard(Client client, string nickname)
    {
        Board board = new Board()
        {
            Nickname = nickname,
            OwnerId = client.ClientId
        };
        return board;
    }

    public Task<Message> SendMessage(long boardId, string message)
    {
        throw new NotImplementedException();
    }
}