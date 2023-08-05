using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class BoardServiceService : IBoardService
{
    public async Task<Board> CreateBoardAsync(Client client, string nickname)
    {
        Board board = new Board()
        {
            Nickname = nickname,
            OwnerId = client.ClientId
        };
        return board;
    }
    
}