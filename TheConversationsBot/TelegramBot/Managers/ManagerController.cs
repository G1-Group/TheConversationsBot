using TheConversationsBot.Domain.Models;
using TheConversationsBot.Service;
using TheConversationsBot.Service.DataSource;
using TheConversationsBot.TelegramBot.Controllers;

namespace TheConversationsBot.TelegramBot.Managers;

public class ManagerController
{
    private readonly AuthService _authService;
    private HomeController _homeController;
    private AuthController _authController;
    private ClientDashboardController _clientDashboardController;
    private BoardController _boardController;
    private ConversationController _conversationController;

    public ManagerController(AuthService authService)
    {
        _authService = authService;
        _homeController = new HomeController();
        _authController = new AuthController(this,authService);
        _clientDashboardController = new ClientDashboardController();
        _boardController = new BoardController(this);
        _conversationController = new ConversationController(this);
    }


    public async Task<ControllerBase> GetControllerBySessionData(Session session)
    {
        return null;
    }
    
}