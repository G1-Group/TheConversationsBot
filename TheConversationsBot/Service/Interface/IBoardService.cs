using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public interface IBoardService
{
    public Task<Board> CreateNewBoard(long ownerId,string nickName);
    public Task<Message> ChangeBoardMessageStatus(long messageId,Message message);
    public Task<Board> StopBoard(long boardId);
    public Task<Board> DeleteBoard(long id);
    public Task<Board> UpdateBoard(long boardId,Board boardModel);
    public Task<Board> GetBoard(long boardId);
    public Task<List<Board>> GetAllBoards();
    public Task<Board> FindBoardByNickName(string nickName);
    public Task<Board> FindByNickName(string nickName);
}