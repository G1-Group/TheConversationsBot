
using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service;
using TheConversationsBot.Service.DataSource;
using TheConversationsBot.Service.Interface;

class Program
{
    static void Main(string[] args)
    {
        DataContext dataContext = new DataContext();
        ClientDataService clientDataService = new ClientDataService(dataContext);
        UserDataService userDataService = new UserDataService(dataContext);
        IAuthService authService = new AuthService(userDataService:userDataService,clientDataService:clientDataService);

        
        
        // authService.Login(new LoginView()
        // {
        //     PhoneNumber = "1234",
        //     Password = "1234"
        // });

    }
}