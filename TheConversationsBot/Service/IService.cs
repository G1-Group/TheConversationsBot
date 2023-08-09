using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service;

public interface IService<T>
{
    Task<T> Cread(T t);
    Task<T> Update(T t);
    Task<T> Delete(T t);
    Task<List<T>> GetAll();
    Task<T> GEtById(long id);
}