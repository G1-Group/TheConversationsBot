namespace TheConversationsBot.Service.Interface;

public interface IAuthService
{
    Task<bool> CheckNickNameAsync(string NickName);
    Task<bool> CheskPhoneNumber(string Number);
    Task<bool> CheckPasswordAsync(string Password);
}