using TheConversationsBot.TelegramBot.Managers;

namespace TheConversationsBot.TelegramBot.Controllers;

public class BoardController: ControllerBase
{
    public BoardController(ManagerController managerController) : base(managerController)
    {
    }

    protected override async Task Index(Context context)
    {
        throw new NotImplementedException();
    }

    protected override async Task HandleAction(Context context)
    {
        throw new NotImplementedException();
    }

    protected override async Task HandleUpdate(Context context)
    {
        throw new NotImplementedException();
    }
}