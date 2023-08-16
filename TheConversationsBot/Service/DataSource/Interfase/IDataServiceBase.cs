using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public interface IDataServiceBase<T> where T : ModelBase
{
    IQueryable<T> GetAll();
    Task<T?> GetByIdAsync(long id);

    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> RemoveAsync(T entity);
    Task<T> RemoveAsync(long id);
}