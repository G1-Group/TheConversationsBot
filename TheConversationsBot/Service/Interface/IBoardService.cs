using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public interface IBoardService:IDataSarvice<Board>
{
    public Task<Board> FindByNickName(string nickName);
}