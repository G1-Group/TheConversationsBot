namespace TheConversationsBot.Service.Interface;

public interface IAuthService
{
    Task<bool> CheckClientAsync(long TelegramClientID);

    Task<bool> CheckClientRegistrationAsync(long TelegramClientID);

}
