namespace TheConversationsBot.Service.DataSource;

public interface DBServiceBase
{
    Task Insert<T>(T model);
    Task Insert<T>(List<T> models);
    Task Delete<T>(T model);
    Task Delete<T>(List<T> models);
    Task Updete<T>(T model);
    Task Updete<T>(List<T> models);
    Task Read<T>(T model);
    Task Read<T>(List<T> models);



}