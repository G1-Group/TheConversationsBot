using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public interface IServiceAnonymChat
{
    public Task<AnonymChat> FindByFromIdOrClientId(long Id);
    public Task<AnonymChat> FindByStatus(int role);
}