namespace TheConversationsBot.Service.Interface;

public interface IAuthService
{
    Task<bool> CheckClient(long TelegramClientID);

    Task<bool> CheckClientRegistration(long TelegramClientID);
    Task<bool> RegistrationNumber(long Id, string Number);
    Task<bool> RegistrationPassword(string Password);
    Task<bool> RegistrationNickname(String Nicknam);


}