using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class BoardService:IBoardService
{
    public Task<Board> CreateData(Board data)
    {
        throw new NotImplementedException();
    }

    public Task<Board> UpdateData(long Id, Board data)
    {
        throw new NotImplementedException();
    }

    public Task<List<Board>> GetAllData()
    {
        throw new NotImplementedException();
    }

    public Task<Board> FindByIdData(long Id)
    {
        throw new NotImplementedException();
    }

    public Task<Board> DeleteData(long Id)
    {
        throw new NotImplementedException();
    }

    public Task<Board> FindByNickName(string nickName)
    {
        throw new NotImplementedException();
    }
}