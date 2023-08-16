using TheConversationsBot.TelegramBot.Managers;

namespace TheConversationsBot.TelegramBot.Controllers;

public class ConversationController:ControllerBase
{
    public ConversationController(ManagerController managerController) : base(managerController)
    {
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