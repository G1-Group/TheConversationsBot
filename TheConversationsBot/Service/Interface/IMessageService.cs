using Telegram.Bot.Types;

namespace TheConversationsBot.Service.Interface;

public interface IMessageService:IDataSarvice<Message>
{
    public Task<Message> FintByFromId(long FromId);
    public Task<List<Message>> GetAllFindBoardId(long BoardId);
}