using Microsoft.EntityFrameworkCore;
using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service.DataSource;
using TheConversationsBot.Service.Interface;

namespace TheConversationsBot.Service;

public class AuthService:IAuthService
{
    private readonly IUserDataService _userDataService;
    private readonly IClientDataService _clientDataService;

    public AuthService(IUserDataService userDataService,IClientDataService clientDataService)
    {
        _userDataService = userDataService;
        _clientDataService = clientDataService;
    }

    public async Task<long> Login(LoginView loginView)
    {
        if (loginView is null)
        {
            throw new Exception("LoginView is null");
        }
        
        var user = _userDataService.GetAll()
            .Where(x =>
                x.Password == loginView.Password &&
                x.PhoneNumber == loginView.PhoneNumber).
            ToList().
            FirstOrDefault();

        if (user is not User)
            throw new Exception("user Not Found");

        
        var client = _clientDataService.
            GetAll().
            Where(x => 
                x.UserId == user.Id).
            ToList().
            FirstOrDefault();

        if (client is not Client)
            throw new Exception("Client not found");

        return client.Id;

    }

    public async Task Registian(SignUpView signUpView)
    {
        if (signUpView is not SignUpView)
        {
            throw new Exception("RegistianView is null");
        }

        var user = await _userDataService.AddAsync(new User()
        {
            Password = signUpView.Password,
            PhoneNumber = signUpView.PhoneNumber,
            TelegramClientId = signUpView.TelegramChatId
        });

        if (user is not User)
            throw new Exception("not create user");
        

        var client = await _clientDataService.AddAsync(new Client()
        {
            Nickname = signUpView.PhoneNumber,
            UserName = signUpView.UserName,
            UserId = user.Id
        });

        if (client is not Client)
            throw new Exception("not create client");



    }
}