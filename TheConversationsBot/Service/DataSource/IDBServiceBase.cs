namespace TheConversationsBot.Service.DataSource;

public interface IDBServiceBase<T>
{
    Task Insert(T model);
    Task Insert(List<T> models);
    Task Delete(T model);
    Task Delete(List<T> models);
    Task Updete(T model);
    Task Updete(List<T> models);
    Task<T> Read(T model);
    Task<T> Read(List<T> models);



}