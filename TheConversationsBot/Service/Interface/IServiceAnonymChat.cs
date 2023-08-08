using TheConversationsBot.Domain.Enums;

namespace TheConversationsBot.Service.Interface;

public interface IServiceAnonymChat
{
    public Task<AnonymChat> FindByFromIdOrClientId(long Id);
    public Task<AnonymChat> FindByStatus(int role);
}