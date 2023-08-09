using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class BoardService:IBoardService
{
    public Task<Board> CreateNewBoard(long ownerId, string nickName)
    {
        throw new NotImplementedException();
    }

    public Task<Message> ChangeBoardMessageStatus(long messageId, Message message)
    {
        throw new NotImplementedException();
    }

    public Task<Board> StopBoard(long boardId)
    {
        throw new NotImplementedException();
    }

    public Task<Board> DeleteBoard(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Board> UpdateBoard(long boardId, Board boardModel)
    {
        throw new NotImplementedException();
    }

    public Task<Board> GetBoard(long boardId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Board>> GetAllBoards()
    {
        throw new NotImplementedException();
    }

    public Task<Board> FindBoardByNickName(string nickName)
    {
        throw new NotImplementedException();
    }

    public Task<Board> FindByNickName(string nickName)
    {
        throw new NotImplementedException();
    }
}