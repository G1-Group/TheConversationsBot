using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public class DataServiceBase<T> : IDataServiceBase<T> where T : ModelBase
{
    public IQueryable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<T?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<T> RemoveAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<T> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }
}