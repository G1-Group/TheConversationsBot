using TheConversationsBot.Domain.Models;

namespace TheConversationsBot.Service.Interface;

public interface IAuthService
{
    Task<long> Login(LoginView loginView);
    Task Registian(SignUpView signUpView);
}