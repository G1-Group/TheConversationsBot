namespace TheConversationsBot.Service.Interface;

public interface IAuthService
{
    Task<bool> CheckClientAsync(long TelegramClientID);
    Task<bool> CheckClientRegistrationAsync(long TelegramClientID);
    Task<bool> RegistrationNumber(long Id, string Number);
    Task<bool> RegistrationPassword(string Password);
    Task<bool> RegistrationNickname(String Nicknam);
    Task<bool> CheckPasswordAsync(string passWord);
    Task<bool> CheckNickNameAsync(string NickName);

}   