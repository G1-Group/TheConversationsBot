namespace TheConversationsBot.Service.Interface;

public interface IAuthService
{
    Task<bool> CheckClient(long TelegramClientID);

    Task<bool> CheckClientRegistration(long TelegramClientID);

    Task<bool> CheckPasswordAsync(string passWord);
    Task<bool> CheckNickNameAsync(string NickName);

}