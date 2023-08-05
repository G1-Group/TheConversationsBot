namespace TheConversationsBot.Service.Interface
{
    public interface ISessionManager<T>
    {
        public Task<T> GetSessionByChatId(long chatId);
    }
}