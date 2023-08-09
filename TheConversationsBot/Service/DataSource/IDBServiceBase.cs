namespace TheConversationsBot.Service.DataSource;

public interface IDBServiceBase<T>
{
    Task<T> Insert(T model);
    Task<List<T>> Insert(List<T> models);
    Task Delete(T model);
    Task Delete(List<T> models);
    Task<T> Updete(T model);
    Task<T> Read(T model);
    Task<List<T>> Read();
}