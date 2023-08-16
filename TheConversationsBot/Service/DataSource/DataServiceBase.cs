using Microsoft.EntityFrameworkCore;
using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.DataSource;

public class DataServiceBase<T> : IDataServiceBase<T> where T : ModelBase
{
    private readonly DbContext _context;

    public DataServiceBase(DbContext context)
    {
        _context = context;
    }

    public IQueryable<T> GetAll()
    {
        return this._context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(long id)
    {
        return await this.GetAll()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<T> AddAsync(T entity)
    {
        var entityEntry = await this._context
            .Set<T>()
            .AddAsync(entity);

        await this._context.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        var entityEntry = this._context
            .Set<T>()
            .Update(entity);

        await this._context.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<T> RemoveAsync(T entity)
    {
        var entityEntry = this._context
            .Set<T>()
            .Remove(entity);

        await this._context.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<T> RemoveAsync(long id)
    {
        var entity = await this.GetByIdAsync(id);
        if (entity is T data)
            return await this.RemoveAsync(data);

        return null;
    }
}