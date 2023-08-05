namespace TheConversationsBot.Service
{
    public interface ISessionManager<T>
    {
        public Task<T> GetSessionByChatId(long chatId);
    }
}